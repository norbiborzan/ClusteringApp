using RestSharp;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClusteringApp
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;
        string predPath = string.Empty;
        ConfusionMatrix singleCM;
        ConfusionMatrix cmKNN;
        ConfusionMatrix cmSVM;
        ConfusionMatrix cmGNB;
        Metrics singleM;
        Metrics mKNN;
        Metrics mSVM;
        Metrics mGNB;

        public Form1()
        {
            InitializeComponent();
            ClearForm();
        }

        /// <summary>
        /// Dataset selection and datagridview population
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ClearForm();
            filePath = Utils.SetDatasetPath(txtFilePath);
            Data.BindData(filePath, dgvDataset, txtFilePath);
            var count = dgvDataset.Columns.Count;
            cbxColumns.Items.Add("none");
            for (int i = 0; i < count; i++)
            {
                cbxColumns.Items.Add(dgvDataset.Columns[i].HeaderText);
            }
            if (cbxColumns.Items.Count > 0)
            {
                cbxColumns.Items.RemoveAt(1);
            } 
        }

        /// <summary>
        /// Checks the mandatory field completion status 
        /// Generates resource address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnStartClustering_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Length > 0)
            {
                if (optDropNaRows.Checked || optDropNaColumns.Checked || optReplaceNan.Checked)
                {
                    if (optKNN.Checked || optSVM.Checked || optBayes.Checked || optCompare.Checked) 
                    {
                        btnStartClustering.Enabled = false;
                        btnClose.Enabled = false;
                        btnBrowse.Enabled = false;

                        var algorithm = Utils.GetAlgorithm(optKNN, optSVM, optBayes, optCompare);
                        var operation = Utils.GetOperation(optDropNaRows, optDropNaColumns, optReplaceNan);
                        var column = "none";

                        if (cbxColumns.SelectedIndex != -1)
                        {
                            column = cbxColumns.SelectedItem.ToString();
                        }

                        var response = await UploadAsync(filePath, "/" + algorithm + "/" + operation + "/" + column);

                        if (response.IsSuccessful)
                        {
                            predPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\pred.csv";
                            File.WriteAllBytes(predPath, Encoding.ASCII.GetBytes(response.Content));
                            if (File.Exists(predPath))
                            {
                                dgvDataset.DataSource = null;
                                Data.BindData(predPath, dgvDataset, txtFilePath);
                                DataAnalysis.HighlightDifferences(dgvDataset, optCompare);
                                if (optCompare.Checked)
                                {
                                    cmKNN = DataAnalysis.GenerateConfusionMatrixForComparison(dgvDataset, 0, 3);
                                    cmSVM = DataAnalysis.GenerateConfusionMatrixForComparison(dgvDataset, 1, 3);
                                    cmGNB = DataAnalysis.GenerateConfusionMatrixForComparison(dgvDataset, 2, 3);
                                    mKNN = DataAnalysis.CalculateMetricsForComparison(dgvDataset, cmKNN);
                                    mSVM = DataAnalysis.CalculateMetricsForComparison(dgvDataset, cmSVM);
                                    mGNB = DataAnalysis.CalculateMetricsForComparison(dgvDataset, cmGNB);
                                    label18.Visible = true;
                                    label19.Visible = true;
                                    optShowKNNCM.Visible = true;
                                    optShowKNNM.Visible = true;
                                    optShowSVMCM.Visible = true;
                                    optShowSVMM.Visible = true;
                                    optShowGNBCM.Visible = true;
                                    optShowGNBM.Visible = true;
                                    optShowKNNCM.Checked = true;
                                    optShowKNNM.Checked = true;
                                }
                                else
                                {
                                    singleCM = DataAnalysis.GenerateConfusionMatrixForComparison(dgvDataset, 0, 1);
                                    txtTN.Text = singleCM.TrueNegativeCount.ToString();
                                    txtTP.Text = singleCM.TruePositiveCount.ToString();
                                    txtFN.Text = singleCM.FalseNegativeCount.ToString();
                                    txtFP.Text = singleCM.FalsePositiveCount.ToString();

                                    singleM = DataAnalysis.CalculateMetricsForComparison(dgvDataset, singleCM);
                                    txtAccuracy.Text = singleM.Accuracy;
                                    txtPrecision.Text = singleM.Precision;
                                    txtPrelevance.Text = singleM.Prelevance;
                                    txtTNRate.Text = singleM.TrueNegativeRate;
                                    txtTPRate.Text = singleM.TruePositiveRate;
                                    txtFPRate.Text = singleM.FalsePositiveRate;

                                    txtCorrectPredCount.Text = (singleCM.TruePositiveCount + singleCM.TrueNegativeCount).ToString();
                                    txtIncorrectPredCount.Text = (singleCM.FalsePositiveCount + singleCM.FalseNegativeCount).ToString();
                                }
                                foreach (DataGridViewColumn col in dgvDataset.Columns)
                                {
                                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                                }
                            }                
                            //Utils.DeleteFile();
                        }
                        else
                        {
                            MessageBox.Show("The server is not responding. \nTry again.", "Server error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        btnStartClustering.Enabled = true;
                        btnClose.Enabled = true;
                        btnBrowse.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Algorithm not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Pre-processing method not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dataset missing. \nImport the dataset using the Load dataset button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        /// <summary>
        /// Async function which send the csv file to the webservice and receives the result
        /// </summary>
        /// <param name="fileName">path to the csv file</param>
        /// <param name="operation">combined string of selected algorithm/preprocessing operation/column name to remove</param>
        /// <returns></returns>
        private async Task<RestResponse> UploadAsync(string fileName, string operation)
        {
            RestClient restClient = new RestClient("http://127.0.0.1:5000/");
            RestRequest restRequest = new RestRequest(operation);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.Post;
            restRequest.AddHeader("Content-Type", "multipart/form-data");
            restRequest.AddFile("content", fileName);
            var restResponse = await restClient.ExecuteAsync(restRequest);

            return restResponse;
        }

        /// <summary>
        /// Populate confusion matrix for KNN in case of algorithm comparison
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optShowKNNCM_CheckedChanged(object sender, EventArgs e)
        {
            txtTN.Text = cmKNN.TrueNegativeCount.ToString();
            txtTP.Text = cmKNN.TruePositiveCount.ToString();
            txtFN.Text = cmKNN.FalseNegativeCount.ToString();
            txtFP.Text = cmKNN.FalsePositiveCount.ToString();
        }

        /// <summary>
        /// Populate confusion matrix for SVM in case of algorithm comparison
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optShowSVMCM_CheckedChanged(object sender, EventArgs e)
        {
            txtTN.Text = cmSVM.TrueNegativeCount.ToString();
            txtTP.Text = cmSVM.TruePositiveCount.ToString();
            txtFN.Text = cmSVM.FalseNegativeCount.ToString();
            txtFP.Text = cmSVM.FalsePositiveCount.ToString();
        }

        /// <summary>
        /// Populate confusion matrix for GNB in case of algorithm comparison
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optShowGNBCM_CheckedChanged(object sender, EventArgs e)
        {
            txtTN.Text = cmGNB.TrueNegativeCount.ToString();
            txtTP.Text = cmGNB.TruePositiveCount.ToString();
            txtFN.Text = cmGNB.FalseNegativeCount.ToString();
            txtFP.Text = cmGNB.FalsePositiveCount.ToString();
        }

        /// <summary>
        /// Populate metrics for KNN in case of algorithm comparison
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optShowKNNM_CheckedChanged(object sender, EventArgs e)
        {
            txtAccuracy.Text = mKNN.Accuracy;
            txtPrecision.Text = mKNN.Precision;
            txtPrelevance.Text = mKNN.Prelevance;
            txtTNRate.Text = mKNN.TrueNegativeRate;
            txtTPRate.Text = mKNN.TruePositiveRate;
            txtFPRate.Text = mKNN.FalsePositiveRate;
            txtCorrectPredCount.Text = (cmKNN.TruePositiveCount + cmKNN.TrueNegativeCount).ToString();
            txtIncorrectPredCount.Text = (cmKNN.FalsePositiveCount + cmKNN.FalseNegativeCount).ToString();
        }

        /// <summary>
        /// Populate metrics for SVM in case of algorithm comparison
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optShowSVMM_CheckedChanged(object sender, EventArgs e)
        {
            txtAccuracy.Text = mSVM.Accuracy;
            txtPrecision.Text = mSVM.Precision;
            txtPrelevance.Text = mSVM.Prelevance;
            txtTNRate.Text = mSVM.TrueNegativeRate;
            txtTPRate.Text = mSVM.TruePositiveRate;
            txtFPRate.Text = mSVM.FalsePositiveRate;
            txtCorrectPredCount.Text = (cmSVM.TruePositiveCount + cmSVM.TrueNegativeCount).ToString();
            txtIncorrectPredCount.Text = (cmSVM.FalsePositiveCount + cmSVM.FalseNegativeCount).ToString();
        }

        /// <summary>
        /// Populate metrics for GNB in case of algorithm comparison
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optShowGNBM_CheckedChanged(object sender, EventArgs e)
        {
            txtAccuracy.Text = mGNB.Accuracy;
            txtPrecision.Text = mGNB.Precision;
            txtPrelevance.Text = mGNB.Prelevance;
            txtTNRate.Text = mGNB.TrueNegativeRate;
            txtTPRate.Text = mGNB.TruePositiveRate;
            txtFPRate.Text = mGNB.FalsePositiveRate;
            txtCorrectPredCount.Text = (cmGNB.TruePositiveCount + cmGNB.TrueNegativeCount).ToString();
            txtIncorrectPredCount.Text = (cmGNB.FalsePositiveCount + cmGNB.FalseNegativeCount).ToString();
        }

        /// <summary>
        /// Clear form an reset controls
        /// </summary>
        private void ClearForm()
        {
            txtTN.Clear();
            txtTP.Clear();
            txtFP.Clear();
            txtFN.Clear();
            txtAccuracy.Clear();
            txtPrecision.Clear();
            txtPrelevance.Clear();
            txtTNRate.Clear();
            txtTPRate.Clear();
            txtFPRate.Clear();
            txtCorrectPredCount.Clear();
            txtIncorrectPredCount.Clear();
            label18.Visible = false;
            label19.Visible = false;
            optShowKNNCM.Visible = false;
            optShowKNNM.Visible = false;
            optShowSVMCM.Visible = false;
            optShowSVMM.Visible = false;
            optShowGNBCM.Visible = false;
            optShowGNBM.Visible = false;
            optShowKNNCM.Checked = false;
            optShowKNNM.Checked = false;
            optShowSVMCM.Checked = false;
            optShowSVMM.Checked = false;
            optShowGNBCM.Checked = false;
            optShowGNBM.Checked = false;
            cbxColumns.DataSource = null;
            cbxColumns.Items.Clear();
        }

        /// <summary>
        /// Ask the user if the form should close.
        /// Called on Close button(btnClose).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the application?", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        /// <summary>
        /// Ask the user if the form should close.
        /// Called on FormClosing event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the application?", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
