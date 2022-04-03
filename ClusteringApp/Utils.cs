using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClusteringApp
{
    public static class Utils
    {
        public static string SetDatasetPath(TextBox textBox)
        {
            var filePath = string.Empty;
            var filePathFull = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\%USERPROFILE%\\Desktop";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    filePathFull = filePath;
                    if (filePath.Length > 50)
                    {
                        filePath = filePath.Substring(filePath.Length - 50);
                        filePath = '\\' + filePath.Substring(filePath.IndexOf('\\') + 1);
                    }
                    textBox.Text = filePath;
                }
            }
            return filePathFull;
        }

        public static string GetAlgorithm(RadioButton knn, RadioButton svm, RadioButton gnb, RadioButton compare)
        {
            string algorithm = string.Empty;

            if (knn.Checked)
            {
                algorithm = "knn";
            }
            else if (svm.Checked)
            {
                algorithm = "svm";
            }
            else if (gnb.Checked)
            {
                algorithm = "gnb";
            }
            else if (compare.Checked)
            {
                algorithm = "compare";
            }

            return algorithm;
        }

        public static string GetOperation(RadioButton rows, RadioButton cols, RadioButton replace)
        {
            string operation = string.Empty;

            if (rows.Checked)
            {
                operation = "dropnarows";
            }
            else if (cols.Checked)
            {
                operation = "dropnacols";
            }
            else if (replace.Checked)
            {
                operation = "replacenan";
            }

            return operation;
        }

        public static void DeleteFile()
        {
            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\pred.csv"))
            {
                File.Delete(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\pred.csv");
            }
        }
    }
}