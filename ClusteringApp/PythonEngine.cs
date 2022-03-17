using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringApp
{
    class PythonEngine
    {
         public void RunPyScript(string script, string datasetPath)
         {
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            ////startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.UseShellExecute = false;
            //startInfo.Arguments = "python3 " + script + ".py "  + "\"" +  datasetPath + "\"";
            //process.StartInfo = startInfo;
            //process.Start();


            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("cmd", "python3 " + "\"" + datasetPath + "\"" + " & exit")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();
         }
    }
}
