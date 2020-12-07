using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcStatsTest
{
    [TestFixture]
    public class CalcStatTests
    {
        private CalcStats calc;
       
        [SetUp]
        public void StartUp()
        {
            calc = new CalcStats();
        }

        [Test]
        [TestCase(new [] {1, 4, 6, 2}, 1)]
        public void Test_minimumValue(int[] stats, int expected)
        {
            calc.Results(stats);

            Assert.AreEqual(calc.MinimumValue(), expected);
        }

        [Test]
        public void Test_maximumValue()
        {
        }

        [Test]
        public void Test_numberOfElementsInTheSequence()
        {
        }

        [Test]
        public void Test_averageValue()
        {
        }
    }
}
