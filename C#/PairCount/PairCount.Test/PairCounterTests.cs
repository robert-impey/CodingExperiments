using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairCount.Lib;

namespace PairCount.Test
{
    [TestClass]
    public class PairCounterTests
    {
        [TestMethod]
        public void EmptyArray()
        {
            Assert.AreEqual(0, PairCounter.Count(0, new int[0]));
        }

        [TestMethod]
        public void SingleElementArray()
        {
            int[] a = { 1 };
            Assert.AreEqual(1, PairCounter.Count(2, a));
        }

        [TestMethod]
        public void SingleElementArrayNoPairs()
        {
            int[] a = { 1 };
            Assert.AreEqual(0, PairCounter.Count(1, a));
        }

        [TestMethod]
        public void TwoDifferentElements()
        {
            int[] a = { 1, 2 };
            Assert.AreEqual(2, PairCounter.Count(3, a));
        }

        [TestMethod]
        public void TwoDifferentElementsNoPairs()
        {
            int[] a = { 1, 2 };
            Assert.AreEqual(0, PairCounter.Count(0, a));
        }

        [TestMethod]
        public void TwoSameNumber()
        {
            int[] a = { 1, 1 };
            Assert.AreEqual(4, PairCounter.Count(2, a));
        }

        [TestMethod]
        public void TwoSameNumberNoPairs()
        {
            int[] a = { 1, 1 };
            Assert.AreEqual(0, PairCounter.Count(1, a));
        }

        [TestMethod]
        public void MixedPairs()
        {
            int[] a = { 1, 2, 3 };
            Assert.AreEqual(3, PairCounter.Count(4, a));
        }

        [TestMethod]
        public void MixedPairsWithRepeats()
        {
            int[] a = { 1, 2, 2, 3 };
            Assert.AreEqual(6, PairCounter.Count(4, a));
        }

        [TestMethod]
        public void Negatives()
        {
            int[] a = { -1 };
            Assert.AreEqual(1, PairCounter.Count(-2, a));
        }
    }
}
