using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace ClusteringApp
{
    class PythonEngine
    {
         public void RunPyScript(string pyClass, string datasetPath)
         {
            //instance of python engine
            var engine = Python.CreateEngine();
            //reading code from file
            var source = engine.CreateScriptSourceFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "script.py"));
            var scope = engine.CreateScope();
            //executing script in scope
            source.Execute(scope);
            var classPy = scope.GetVariable(pyClass);
            //initializing class
            var classIntance = engine.Operations.CreateInstance(classPy);
            classIntance.func(datasetPath);
         }
    }
}
