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
        /// <summary>
        /// Open a browse window end select the .csv file
        /// Get the last 50 characters of the path to display it in the txtFilePath textbox
        /// Return the full path as string
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Return the selected algoritm as string
        /// </summary>
        /// <param name="knn"></param>
        /// <param name="svm"></param>
        /// <param name="gnb"></param>
        /// <param name="compare"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Return the selected data pre-processing operation
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="replace"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Deletes the pred.csv file if it exists
        /// </summary>
        public static void DeleteFile()
        {
            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\pred.csv"))
            {
                File.Delete(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\pred.csv");
            }
        }
    }
}