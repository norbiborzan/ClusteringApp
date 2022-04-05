using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringApp
{   
    public class Metrics
    {
        public string Accuracy { get; set; }
        public string Precision { get; set; }
        public string Prelevance { get; set; }
        public string TruePositiveRate { get; set; }
        public string FalsePositiveRate { get; set; }
        public string TrueNegativeRate { get; set; }

        public Metrics(string accuracy, string precision, string prelevance, string tprate, string fprate, string tnrate)
        {
            Accuracy = accuracy;
            Precision = precision;
            Prelevance = prelevance;
            TruePositiveRate = tprate;
            FalsePositiveRate = fprate;
            TrueNegativeRate = tnrate;
        }
    }
}
