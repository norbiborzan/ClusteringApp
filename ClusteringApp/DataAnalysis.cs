using System;
using System.Windows.Forms;

namespace ClusteringApp
{
    public static class DataAnalysis
    {
        public static void GenerateConfusionMatrix(DataGridView dgv, TextBox tn, TextBox fp, TextBox fn, TextBox tp, int predColIndex, int trueColIndex)
        {
            int tnCounter = 0;
            int fpCounter = 0;
            int fnCounter = 0;
            int tpCounter = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
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

            tn.Text = tnCounter.ToString();
            tp.Text = tpCounter.ToString();
            fn.Text = fnCounter.ToString();
            fp.Text = fpCounter.ToString();
        }

        public static ConfusionMatrix GenerateConfusionMatrixForComparison(DataGridView dgv, int predColIndex, int trueColIndex)
        {
            int tnCounter = 0;
            int fpCounter = 0;
            int fnCounter = 0;
            int tpCounter = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
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

        public static void CalculateMetrics(DataGridView dgv, TextBox tn, TextBox fp, TextBox fn, TextBox tp, TextBox accuracy, TextBox precision, TextBox prelevance, TextBox tprate, TextBox fprate, TextBox tnrate)
        {
            if (tn.Text.Length > 0 && fp.Text.Length > 0 && fn.Text.Length > 0 && tp.Text.Length > 0)
            {
                float acc = (float.Parse(tp.Text) + float.Parse(tn.Text)) / dgv.Rows.Count;
                accuracy.Text = Math.Round(acc * 100, 3).ToString();

                float prec = float.Parse(tp.Text) / (float.Parse(tp.Text) + float.Parse(fp.Text));
                precision.Text = Math.Round(prec * 100, 3).ToString(); ;

                float prel = (float.Parse(tp.Text) + float.Parse(fn.Text)) / dgv.Rows.Count;
                prelevance.Text = Math.Round(prel * 100, 3).ToString();

                float tpr = float.Parse(tp.Text) / (float.Parse(tp.Text) + (float.Parse(fn.Text)));
                tprate.Text = Math.Round(tpr * 100, 3).ToString();

                float fpr = float.Parse(fp.Text) / (float.Parse(tn.Text) + (float.Parse(fp.Text)));
                fprate.Text = Math.Round(fpr * 100, 3).ToString();

                float tnr = float.Parse(tn.Text) / (float.Parse(tn.Text) + (float.Parse(fp.Text)));
                tnrate.Text = Math.Round(tnr * 100, 3).ToString();
            }
        }

        public static Metrics CalculateMetricsForComparison(DataGridView dgv, ConfusionMatrix cm)
        {
            string accuracy = string.Empty;
            string precision = string.Empty;
            string prelevance = string.Empty;
            string tprate = string.Empty;
            string fprate = string.Empty;
            string tnrate = string.Empty;

            //if (cm.TrueNegativeCount != null && cm.TruePositiveCount != null && cm.FalseNegativeCount != null && cm.FalsePositiveCount != null)
            //{
                float acc = ((float)cm.TruePositiveCount + (float)cm.TrueNegativeCount) / (float)dgv.Rows.Count;
                accuracy = Math.Round(acc * 100, 3).ToString();

                float prec = (float)cm.TruePositiveCount / ((float)cm.TruePositiveCount + (float)cm.FalsePositiveCount);
                precision = Math.Round(prec * 100, 3).ToString(); ;

                float prel = ((float)cm.TruePositiveCount + (float)cm.FalseNegativeCount) / (float)dgv.Rows.Count;
                prelevance = Math.Round(prel * 100, 3).ToString();

                float tpr = (float)cm.TruePositiveCount / ((float)cm.TruePositiveCount + (float)cm.FalseNegativeCount);
                tprate = Math.Round(tpr * 100, 3).ToString();

                float fpr = (float)cm.FalsePositiveCount / ((float)cm.TrueNegativeCount + (float)cm.FalsePositiveCount);
                fprate = Math.Round(fpr * 100, 3).ToString();

                float tnr = (float)cm.TrueNegativeCount / ((float)cm.TrueNegativeCount + (float)cm.FalsePositiveCount);
                tnrate = Math.Round(tnr * 100, 3).ToString();
            //}

            var metrics = new Metrics(accuracy, precision, prelevance, tprate, fprate, tnrate);
            return metrics;
        }
    }
}
