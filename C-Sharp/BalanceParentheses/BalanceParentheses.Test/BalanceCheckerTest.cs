﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalanceParentheses.Lib;

namespace BalanceParentheses.Test
{
    [TestClass]
    public class BalanceCheckerTest
    {
        [TestMethod]
        public void TestEmptyString()
        {
            Assert.IsTrue(BalanceChecker.IsStringBalanced(""));
        }

        [TestMethod]
        public void TestSimplestBalanced()
        {
            Assert.IsTrue(BalanceChecker.IsStringBalanced("()"));
        }

        [TestMethod]
        public void TestSingleOpening()
        {
            Assert.IsFalse(BalanceChecker.IsStringBalanced("("));
        }

        [TestMethod]
        public void TestSingleClosing()
        {
            Assert.IsFalse(BalanceChecker.IsStringBalanced(")"));
        }

        [TestMethod]
        public void TestBalancedNested()
        {
            Assert.IsTrue(BalanceChecker.IsStringBalanced("(())"));
        }

        [TestMethod]
        public void TestBalancedMultipleNested()
        {
            Assert.IsTrue(BalanceChecker.IsStringBalanced("(()())"));
        }

        [TestMethod]
        public void TestBalancedWithOtherWords()
        {
            Assert.IsTrue(BalanceChecker.IsStringBalanced("(foo)(bar)"));
        }

        [TestMethod]
        public void TestUnbalancedNested()
        {
            Assert.IsFalse(BalanceChecker.IsStringBalanced("(()"));
        }

        [TestMethod]
        public void TestReversedBalanced()
        {
            Assert.IsFalse(BalanceChecker.IsStringBalanced(")("));
        }
    }
}
