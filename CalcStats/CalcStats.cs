using System;
using System.Linq;

namespace CalcStatsTest
{
    public class CalcStats
    {
        public int MinimumValue { get; private set; }

        internal void Results(int[] stats)
        {
            MinimumValue = stats.Min();
        }
}