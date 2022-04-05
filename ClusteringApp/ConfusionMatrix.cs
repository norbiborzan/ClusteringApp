using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringApp
{
    public class ConfusionMatrix
    {
        public int TrueNegativeCount { get; set; }
        public int TruePositiveCount { get; set; }
        public int FalseNegativeCount { get; set; }
        public int FalsePositiveCount { get; set; }

        public ConfusionMatrix(int trueNeg, int truePos, int falseNeg, int falsePos)
        {
            TrueNegativeCount = trueNeg;
            TruePositiveCount = truePos;
            FalseNegativeCount = falseNeg;
            FalsePositiveCount = falsePos;
        }
    }
}
