using System;
using System.Linq;

namespace CalcStatsTest
{
    public class CalcStats
    {
        public int MinimumValue { get; private set; }
        public int MaximumValue { get; internal set; }
        public int NumberOfElementsInTheSequence { get; internal set; }
        public double AverageValue { get; internal set; }

        public void Results(int[] stats)
        {
            MinimumValue = stats.Min();
            MaximumValue = stats.Max();
            NumberOfElementsInTheSequence = stats.Length;
            AverageValue = stats.Average();
        }
    }
}