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
            string algorithm = string.Empty;
            string operation = string.Empty;

            if (predColumnAdded == true)
            {
                dgvDataset.Columns.RemoveAt(0);
                Data.RemoveHighlight(dgvDataset);
            }

            if (optKNN.Checked)
            {
                algorithm = "knn";
            }
            else if (optSVM.Checked)
            {
                algorithm = "svm";
            }
            else if (optBayes.Checked)
            {
                algorithm = "gnb";
            }
            else if (optCompare.Checked)
            {
                algorithm = "compare";
            }

            if (optDropNaRows.Checked)
            {
                operation = "dropnarows";
            }
            else if (optDropNaColumns.Checked)
            {
                operation = "dropnacols";
            }
            else if (optReplaceNan.Checked)
            {
                operation = "replacenan";
            }

            await UploadAsync(filePath, "/" + algorithm + "/" + operation);

            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv"))
            {
                Data.AddPredictedColumn(dgvDataset, Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv");
                Data.HighlightDifferences(dgvDataset);
                predColumnAdded = true;
            }

            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv"))
            {
                File.Delete(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv"))
            {
                File.Delete(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv");
            }
            Close();
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
                predPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\pred.csv";
                File.WriteAllBytes(predPath, Encoding.ASCII.GetBytes(restResponse.Content));
            }
            return restResponse;
        }
    }
}
