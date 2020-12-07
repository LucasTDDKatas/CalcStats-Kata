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

            Assert.AreEqual(calc.MinimumValue, expected);
        }

        [Test]
        [TestCase(new[] {44, 32, 1, 2, 100 }, 100)]
        public void Test_maximumValue(int[] stats, int expected)
        {
            calc.Results(stats);

            Assert.AreEqual(calc.MaximumValue, expected);
        }

        [Test]
        [TestCase(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10)]
        public void Test_numberOfElementsInTheSequence(int[] stats, int expected)
        {
            calc.Results(stats);

            Assert.AreEqual(calc.NumberOfElementsInTheSequence, expected);
        }

        [Test]
        [TestCase(new[] {5, 6, 3, 7, 7, 5}, 5.5)]
        public void Test_averageValue(int[] stats, double expected)
        {
            calc.Results(stats);

            Assert.AreEqual(calc.AverageValue, expected);
        }
    }
}
