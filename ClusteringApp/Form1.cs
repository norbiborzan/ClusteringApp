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

namespace ClusteringApp
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            filePath = Utils.SetDatasetPath(txtFilePath);
            BindData(filePath);
        }

        private void btnStartClustering_Click(object sender, EventArgs e)
        {
            var pyEgine = new PythonEngine();
            if (optKNN.Checked)
            {
                if (optDropNaRows.Checked)
                {
                    pyEgine.RunPyScript("knn_dropna_row", filePath);
                }
                else if (optDropNaColumns.Checked)
                {
                    pyEgine.RunPyScript("knn_dropna_col", filePath);
                }
                else if (optReplaceNan.Checked)
                {
                    pyEgine.RunPyScript("knn_replace", filePath);
                }
            }
            else if (optSVM.Checked)
            {

            }
            else if (optBayes.Checked)
            {

            }
            else if (optCompare.Checked)
            {

            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BindData(string filePath)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] lines = System.IO.File.ReadAllLines(filePath);
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
                return;
            }

        }
    }
}
