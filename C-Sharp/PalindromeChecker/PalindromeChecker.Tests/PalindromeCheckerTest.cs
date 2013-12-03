using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker.Lib;

namespace PalindromeChecker.Tests
{
    [TestClass]
    public class PalindromeCheckerTest
    {
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsFalse(PalindromeChecker.Lib.PalindromeChecker.IsPalindrome(""));
        }

        [TestMethod]
        public void SingleLetter()
        {
            Assert.IsTrue(PalindromeChecker.Lib.PalindromeChecker.IsPalindrome("a"));
        }

        [TestMethod]
        public void TwoLetterPalindrome()
        {
            Assert.IsTrue(PalindromeChecker.Lib.PalindromeChecker.IsPalindrome("aa"));
        }

        [TestMethod]
        public void TwoDifferentLetters()
        {
            Assert.IsFalse(PalindromeChecker.Lib.PalindromeChecker.IsPalindrome("ab"));
        }

        [TestMethod]
        public void ThreeLetterPalindrome()
        {
            Assert.IsTrue(PalindromeChecker.Lib.PalindromeChecker.IsPalindrome("aba"));
        }

        [TestMethod]
        public void FourLetterPalindrome()
        {
            Assert.IsTrue(PalindromeChecker.Lib.PalindromeChecker.IsPalindrome("abba"));
        }

        [TestMethod]
        public void FourLetterRepeats()
        {
            Assert.IsFalse(PalindromeChecker.Lib.PalindromeChecker.IsPalindrome("abab"));
        }
    }
}
