using System;
using System.Collections.Generic;
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
    }
}
