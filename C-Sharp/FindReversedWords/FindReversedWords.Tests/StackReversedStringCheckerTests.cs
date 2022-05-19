using FindReversedWords.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindReversedWords.Tests
{
    [TestClass]
    public class StackReversedStringCheckerTests
    {
        private IReversedStringChecker reversedStringChecker;

        [TestInitialize]
        public void TestInitialize()
        {
            reversedStringChecker = new StackReversedStringChecker();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            reversedStringChecker = null;
        }

        [TestMethod]
        public void EmptyStrings()
        {
            Assert.IsTrue(reversedStringChecker.AreReversedPair(string.Empty, string.Empty));
        }

        [TestMethod]
        public void SameSingleCharStrings()
        {
            Assert.IsTrue(reversedStringChecker.AreReversedPair("a", "a"));
        }

        [TestMethod]
        public void DifferentSingleCharStrings()
        {
            Assert.IsFalse(reversedStringChecker.AreReversedPair("a", "b"));
        }

        [TestMethod]
        public void SameMultiCharStrings()
        {
            Assert.IsFalse(reversedStringChecker.AreReversedPair("ab", "ab"));
        }

        [TestMethod]
        public void ReversedMultiCharsStrings()
        {
            Assert.IsTrue(reversedStringChecker.AreReversedPair("ab", "ba"));
        }

        [TestMethod]
        public void ReversedMultiCharsStringsWithExtraChar()
        {
            Assert.IsFalse(reversedStringChecker.AreReversedPair("ab", "baa"));
        }
    }
}
