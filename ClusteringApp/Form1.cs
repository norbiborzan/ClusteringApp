using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using RestSharp.Extensions;

namespace ClusteringApp
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;
        string predPath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            filePath = Utils.SetDatasetPath(txtFilePath);
            BindData(filePath);
        }

        private async Task<RestResponse> UploadAsync(string fileName, string operation)
        {
            RestClient restClient = new RestClient("http://127.0.0.1:5000/");
            RestRequest restRequest = new RestRequest(operation);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.Post;
            //restRequest.AddHeader("Authorization", "Authorization");
            restRequest.AddHeader("Content-Type", "multipart/form-data");
            restRequest.AddFile("content", fileName);
            var restResponse = await restClient.ExecuteAsync(restRequest);

            if (restResponse.IsSuccessful)
            {
                predPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv";
                File.WriteAllBytes(predPath, Encoding.ASCII.GetBytes(restResponse.Content));
            }
            return restResponse;
        }

        private async void btnStartClustering_Click(object sender, EventArgs e)
        {
            if (optKNN.Checked)
            {
                if (optDropNaRows.Checked)
                {
                    await UploadAsync(filePath, "/knn/dropnarows");
                }
                else if (optDropNaColumns.Checked)
                {
                    await UploadAsync(filePath, "knn/dropnacols");
                }
                else if (optReplaceNan.Checked)
                {
                    await UploadAsync(filePath, "knn/replacenan");
                }
            }
            else if (optSVM.Checked)
            {
                if (optDropNaRows.Checked)
                {
                    await UploadAsync(filePath, "svm/dropnarows");
                }
                else if (optDropNaColumns.Checked)
                {
                    await UploadAsync(filePath, "svm/dropnacols");
                }
                else if (optReplaceNan.Checked)
                {
                    await UploadAsync(filePath, "svm/replacenan");
                }
            }
            else if (optBayes.Checked)
            {
                if (optDropNaRows.Checked)
                {
                    await UploadAsync(filePath, "gnb/dropnarows");
                }
                else if (optDropNaColumns.Checked)
                {
                    await UploadAsync(filePath, "gnb/dropnacols");
                }
                else if (optReplaceNan.Checked)
                {
                    await UploadAsync(filePath, "gnb/replacenan");
                }
            }
            else if (optCompare.Checked)
            {

            }

            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv"))
            {
                AddPredictedColumn(dgvDataset, System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv");
                HighlightDifferences(dgvDataset);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv"))
            {

            }
            File.Delete(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv");
            Close();
        }

        private void BindData(string filePath)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    //First line to create header
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    //For Data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    dgvDataset.DataSource = dt;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("CSV file in use. \nClose the file and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFilePath.Clear();
                return;
            } 
            catch (ArgumentException ex)
            {
                txtFilePath.Clear();
                return;
            }
        }

        private void AddPredictedColumn(DataGridView dgv, string predPath)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Predicted Value";
            dgv.Columns.Insert(0, column);

            string[] lines = File.ReadLines(predPath).ToArray();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["Predicted Value"].Value = lines[i];
            }
        }

        private void HighlightDifferences(DataGridView dgv)
        {
            int counter = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[0].Value.Equals(dgv.Rows[i].Cells[1].Value))
                {
                    dgv.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    dgv.Rows[i].Cells[1].Style.BackColor = Color.Green;
                }
                else
                {
                    dgv.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgv.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    counter++;
                }
            }
            MessageBox.Show($"From a total of {dgv.Rows.Count} entries, {counter} values were incorrectly predicted by the selected algorithm.");
        }
    }
}
