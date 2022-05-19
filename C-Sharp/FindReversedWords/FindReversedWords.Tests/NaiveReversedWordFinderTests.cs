using FindReversedWords.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FindReversedWords.Tests
{
    [TestClass]
    public class NaiveReversedWordFinderTests
    {
        private IReversedWordFinder reversedWordFinder;
        private IQueryable<string> emptyStringList;

        private ICollection emptyReversedWordPairs;

        private IEnumerable<string> wordsWithoutReversedWords;
        private IEnumerable<string> wordsWithReversedWords;
        private IEnumerable<string> wordsWithPalindrone;

        [TestInitialize]
        public void Initialize()
        {
            reversedWordFinder = new NaiveReversedWordFinder();
            emptyStringList = new List<string>().AsQueryable();
            emptyReversedWordPairs = new ReversedWordPair[0];
            wordsWithoutReversedWords = new[] { "apple", "banana", "coconut" };
            wordsWithReversedWords = new[] { "note", "eton", "tone" };
            wordsWithPalindrone = new[] { "noon" };
        }

        [TestCleanup]
        public void Cleanup()
        {
            reversedWordFinder = null;
            emptyStringList = null;

            emptyReversedWordPairs = null;
            wordsWithoutReversedWords = null;
            wordsWithReversedWords = null;
            wordsWithPalindrone = null;
        }

        [TestMethod]
        public void EmptyList()
        {
            var foundPairs = FindPairs(emptyStringList);
            CollectionAssert.AreEqual(emptyReversedWordPairs, foundPairs.ToList());
        }

        [TestMethod]
        public void ListWithoutReversedWords()
        {
            var foundPairs = FindPairs(wordsWithoutReversedWords);
            CollectionAssert.AreEqual(emptyReversedWordPairs, foundPairs.ToList());
        }

        [TestMethod]
        public void ListWithReversedWords()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithReversedWords);
            Assert.IsTrue(foundPairs.Contains(new ReversedWordPair("eton", "note")));
        }

        [TestMethod]
        public void ListWithReversedWordsReverseOrder()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithReversedWords);
            Assert.IsTrue(foundPairs.Contains(new ReversedWordPair("note", "eton")));
        }

        [TestMethod]
        public void ListWithReversedWordsCount()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithReversedWords);
            Assert.AreEqual(2, foundPairs.Count());
        }

        [TestMethod]
        public void ListWithPalindroneItem()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithPalindrone);
            Assert.IsTrue(foundPairs.Contains(new ReversedWordPair("noon", "noon")));
        }

        [TestMethod]
        public void ListWithPalindroneCount()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithPalindrone);
            Assert.AreEqual(1, foundPairs.Count());
        }

        private IEnumerable<ReversedWordPair> FindPairs(IEnumerable<string> words)
        {
            return reversedWordFinder.FindReversedWords(words.AsQueryable());
        }
    }
}
