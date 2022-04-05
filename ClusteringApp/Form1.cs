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
        bool predColumnAdded = false;
        ConfusionMatrix cmKNN;
        ConfusionMatrix cmSVM;
        ConfusionMatrix cmGNB;
        Metrics mKNN;
        Metrics mSVM;
        Metrics mGNB;

        public Form1()
        {
            InitializeComponent();
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
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            filePath = Utils.SetDatasetPath(txtFilePath);
            Data.BindData(filePath, dgvDataset, txtFilePath);
        }

        private async void btnStartClustering_Click(object sender, EventArgs e)
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

            if (txtFilePath.Text.Length > 0)
            {
                if (optDropNaRows.Checked || optDropNaColumns.Checked || optReplaceNan.Checked)
                {
                    if (optKNN.Checked || optSVM.Checked || optBayes.Checked || optCompare.Checked) 
                    {
                        btnStartClustering.Enabled = false;
                        btnClose.Enabled = false;
                        btnBrowse.Enabled = false;

                        if (predColumnAdded == true)
                        {
                            dgvDataset.Columns.RemoveAt(0);
                            Data.RemoveHighlight(dgvDataset);
                        }

                        var response = await UploadAsync(filePath, "/" + Utils.GetAlgorithm(optKNN, optSVM, optBayes, optCompare) + "/" + Utils.GetOperation(optDropNaRows, optDropNaColumns, optReplaceNan));

                        if (response.IsSuccessful)
                        {
                            predPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\pred.csv";
                            File.WriteAllBytes(predPath, Encoding.ASCII.GetBytes(response.Content));
                            if (File.Exists(predPath))
                            {
                                dgvDataset.DataSource = null;
                                Data.BindData(predPath, dgvDataset, txtFilePath);
                                Data.HighlightDifferences(dgvDataset, optCompare);
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
                                    DataAnalysis.GenerateConfusionMatrix(dgvDataset, txtTN, txtFP, txtFN, txtTP, 0, 1);
                                    DataAnalysis.CalculateMetrics(dgvDataset, txtTN, txtFP, txtFN, txtTP, txtAccuracy, txtPrecision, txtPrelevance, txtTPRate, txtFPRate, txtTNRate);
                                }
                                predColumnAdded = true;
                                foreach (DataGridViewColumn column in dgvDataset.Columns)
                                {
                                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                                }
                            }                
                            Utils.DeleteFile();
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

        private void optShowKNNCM_CheckedChanged(object sender, EventArgs e)
        {
            txtTN.Text = cmKNN.TrueNegativeCount.ToString();
            txtTP.Text = cmKNN.TruePositiveCount.ToString();
            txtFN.Text = cmKNN.FalseNegativeCount.ToString();
            txtFP.Text = cmKNN.FalsePositiveCount.ToString();
        }

        private void optShowSVMCM_CheckedChanged(object sender, EventArgs e)
        {
            txtTN.Text = cmSVM.TrueNegativeCount.ToString();
            txtTP.Text = cmSVM.TruePositiveCount.ToString();
            txtFN.Text = cmSVM.FalseNegativeCount.ToString();
            txtFP.Text = cmSVM.FalsePositiveCount.ToString();
        }

        private void optShowGNBCM_CheckedChanged(object sender, EventArgs e)
        {
            txtTN.Text = cmGNB.TrueNegativeCount.ToString();
            txtTP.Text = cmGNB.TruePositiveCount.ToString();
            txtFN.Text = cmGNB.FalseNegativeCount.ToString();
            txtFP.Text = cmGNB.FalsePositiveCount.ToString();
        }

        private void optShowKNNM_CheckedChanged(object sender, EventArgs e)
        {
            txtAccuracy.Text = mKNN.Accuracy;
            txtPrecision.Text = mKNN.Precision;
            txtPrelevance.Text = mKNN.Prelevance;
            txtTNRate.Text = mKNN.TrueNegativeRate;
            txtTPRate.Text = mKNN.TruePositiveRate;
            txtFPRate.Text = mKNN.FalsePositiveRate;
        }

        private void optShowSVMM_CheckedChanged(object sender, EventArgs e)
        {
            txtAccuracy.Text = mSVM.Accuracy;
            txtPrecision.Text = mSVM.Precision;
            txtPrelevance.Text = mSVM.Prelevance;
            txtTNRate.Text = mSVM.TrueNegativeRate;
            txtTPRate.Text = mSVM.TruePositiveRate;
            txtFPRate.Text = mSVM.FalsePositiveRate;
        }

        private void optShowGNBM_CheckedChanged(object sender, EventArgs e)
        {
            txtAccuracy.Text = mGNB.Accuracy;
            txtPrecision.Text = mGNB.Precision;
            txtPrelevance.Text = mGNB.Prelevance;
            txtTNRate.Text = mGNB.TrueNegativeRate;
            txtTPRate.Text = mGNB.TruePositiveRate;
            txtFPRate.Text = mGNB.FalsePositiveRate;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }

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
    }
}
