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
        /// Proper divisors of 10 are
        /// 1, 2, 5
        /// Sum: 8
        /// </summary>
        [TestMethod]
        public void SumOfDivisorsOf10()
        {
            Assert.AreEqual(8, Calculate(10));
        }

        /// <summary>
        /// Proper divisors of 36 are
        /// 1 + 2 + 3 + 4 + 6 + 9 + 12 + 18 = 55 
        /// </summary>
        [TestMethod]
        public void SumOfDivisorsOf36()
        {
            Assert.AreEqual(55, Calculate(36));
        }
    }
}
