using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeChecker.Tests
{
    [TestClass]
    public class PalindromeCheckerTest
    {
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsFalse(Lib.PalindromeChecker.IsPalindrome(""));
        }

        [TestMethod]
        public void SingleLetter()
        {
            Assert.IsTrue(Lib.PalindromeChecker.IsPalindrome("a"));
        }

        [TestMethod]
        public void TwoLetterPalindrome()
        {
            Assert.IsTrue(Lib.PalindromeChecker.IsPalindrome("aa"));
        }

        [TestMethod]
        public void TwoDifferentLetters()
        {
            Assert.IsFalse(Lib.PalindromeChecker.IsPalindrome("ab"));
        }

        [TestMethod]
        public void ThreeLetterPalindrome()
        {
            Assert.IsTrue(Lib.PalindromeChecker.IsPalindrome("aba"));
        }

        [TestMethod]
        public void FourLetterPalindrome()
        {
            Assert.IsTrue(Lib.PalindromeChecker.IsPalindrome("abba"));
        }

        [TestMethod]
        public void FourLetterRepeats()
        {
            Assert.IsFalse(Lib.PalindromeChecker.IsPalindrome("abab"));
        }
    }
}
