using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ClusteringApp
{
    public static class Data
    {
        /// <summary>
        /// Populates the datagridview and sets the filepath textbox
        /// </summary>
        /// <param name="filePath">Selected file path</param>
        /// <param name="dgv">Datagridview</param>
        /// <param name="textBox">Filepath textbox</param>
        public static void BindData(string filePath, DataGridView dgv, TextBox textBox)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
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
                    dgv.DataSource = dt;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("CSV file in use. \nClose the file and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Clear();
                return;
            }
            catch (ArgumentException ex)
            {
                textBox.Clear();
                return;
            }
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
