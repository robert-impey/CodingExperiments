using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static SumOfProperDivisors.Lib.SumOfProperDivisors;

namespace SumOfProperDivisors.Tests
{
    [TestClass]
    public class SumTests
    {
        [TestMethod]
        public void SumOfDivisorsOfZero()
        {
            Assert.AreEqual(0, Calculate(0));
        }

        [TestMethod]
        public void SumOfDivisorsOfOne()
        {
            Assert.AreEqual(1, Calculate(1));
        }

        /// <summary>
        /// Divisors of 24 are
        /// 1, 2, 3, 4, 6, 8, 12, 24
        /// Sum: 60
        /// </summary>
        [TestMethod]
        public void SumOfDivisorsOf24()
        {
            Assert.AreEqual(60, Calculate(24));
        }
    }
}
