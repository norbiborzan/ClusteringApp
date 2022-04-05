using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClusteringApp
{
    public static class Data
    {
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

        //not used
        public static  void AddPredictedColumn(DataGridView dgv, string predPath)
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

        public static void HighlightDifferences(DataGridView dgv, RadioButton radio)
        {
            int counter = 0;
            if (radio.Checked)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.Equals(dgv.Rows[i].Cells[3].Value))
                    {
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    }
                    if (dgv.Rows[i].Cells[1].Value.Equals(dgv.Rows[i].Cells[3].Value))
                    {
                        dgv.Rows[i].Cells[1].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    }
                    if (dgv.Rows[i].Cells[2].Value.Equals(dgv.Rows[i].Cells[3].Value))
                    {
                        dgv.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    }
                }
            }
            else
            {
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

        public static void RemoveHighlight(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dgv.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
    }
}
