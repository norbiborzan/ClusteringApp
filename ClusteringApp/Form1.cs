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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            filePath = Utils.SetDatasetPath(txtFilePath);
            Data.BindData(filePath, dgvDataset, txtFilePath);
        }

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
                                //Data.AddPredictedColumn(dgvDataset, predPath);
                                dgvDataset.DataSource = null;
                                Data.BindData(predPath, dgvDataset, txtFilePath);
                                Data.HighlightDifferences(dgvDataset);
                                DataAnalysis.GenerateConfusionMatrix(dgvDataset, txtTN, txtFP, txtFN, txtTP);
                                DataAnalysis.CalculateMetrics(dgvDataset, txtTN, txtFP, txtFN, txtTP,txtAccuracy, txtPrecision, txtPrelevance, txtTPRate, txtFPRate, txtTNRate);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
