using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClusteringApp
{
    public static class DataAnalysis
    {
        /// <summary>
        /// Calculates and returns a ConfusionMatrix object based on the values of the Pedicted Class and True Class.
        /// </summary>
        /// <param name="dgv">DataGridView</param>
        /// <param name="predColIndex">Predicted Class Column of the DataGridView</param>
        /// <param name="trueColIndex">True Class Column of the DataGridView</param>
        /// <returns></returns>
        public static ConfusionMatrix GenerateConfusionMatrixForComparison(DataGridView dgv, int predColIndex, int trueColIndex)
        {
            int tnCounter = 0;
            int fpCounter = 0;
            int fnCounter = 0;
            int tpCounter = 0;

            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (dgv.Rows[i].Cells[predColIndex].Value.Equals("0") && dgv.Rows[i].Cells[trueColIndex].Value.Equals("0"))
                {
                    tpCounter++;
                }
                else if (dgv.Rows[i].Cells[predColIndex].Value.Equals("1") && dgv.Rows[i].Cells[trueColIndex].Value.Equals("1"))
                {
                    tnCounter++;
                }
                else if (dgv.Rows[i].Cells[predColIndex].Value.Equals("1") && dgv.Rows[i].Cells[trueColIndex].Value.Equals("0"))
                {
                    fnCounter++;
                }
                else if (dgv.Rows[i].Cells[predColIndex].Value.Equals("0") && dgv.Rows[i].Cells[trueColIndex].Value.Equals("1"))
                {
                    fpCounter++;
                }
            }

            var cm = new ConfusionMatrix(tnCounter, tpCounter, fnCounter, fpCounter);
            return cm;
        }

        /// <summary>
        /// Calculates and returns a Metrics object based on the values of the ConfusionMatrix and the number of rows of the GridView.
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="cm"></param>
        /// <returns></returns>
        public static Metrics CalculateMetricsForComparison(DataGridView dgv, ConfusionMatrix cm)
        {
            string accuracy = string.Empty;
            string precision = string.Empty;
            string prelevance = string.Empty;
            string tprate = string.Empty;
            string fprate = string.Empty;
            string tnrate = string.Empty;

            float acc = ((float)cm.TruePositiveCount + (float)cm.TrueNegativeCount) / ((float)dgv.Rows.Count - 1);
            accuracy = Math.Round(acc * 100, 2).ToString();

            float prec = (float)cm.TruePositiveCount / ((float)cm.TruePositiveCount + (float)cm.FalsePositiveCount);
            precision = Math.Round(prec * 100, 2).ToString(); 

            float prel = ((float)cm.TruePositiveCount + (float)cm.FalseNegativeCount) / ((float)dgv.Rows.Count - 1);
            prelevance = Math.Round(prel * 100, 2).ToString();

            float tpr = (float)cm.TruePositiveCount / ((float)cm.TruePositiveCount + (float)cm.FalseNegativeCount);
            tprate = Math.Round(tpr * 100, 2).ToString();

            float fpr = (float)cm.FalsePositiveCount / ((float)cm.TrueNegativeCount + (float)cm.FalsePositiveCount);
            fprate = Math.Round(fpr * 100, 2).ToString();

            float tnr = (float)cm.TrueNegativeCount / ((float)cm.TrueNegativeCount + (float)cm.FalsePositiveCount);
            tnrate = Math.Round(tnr * 100, 2).ToString();

            var metrics = new Metrics(accuracy, precision, prelevance, tprate, fprate, tnrate);
            return metrics;
        }

        /// <summary>
        /// Highlights the differences between true class and predicted classes
        /// </summary>
        /// <param name="dgv">Datagridview</param>
        /// <param name="radio">optCompare for algorithm comparison</param>
        public static void HighlightDifferences(DataGridView dgv, RadioButton radio)
        {
            int counter = 0;
            if (radio.Checked)
            {
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
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
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
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
            }
        }
    }
}
