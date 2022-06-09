using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringApp
{
    /// <summary>
    /// Holds the confusion matrix values based on the data of the True Class and Predicted Class.
    /// </summary>
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
