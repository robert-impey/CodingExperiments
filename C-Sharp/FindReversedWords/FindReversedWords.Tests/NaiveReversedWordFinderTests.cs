using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindReversedWords.Lib;
using System.Collections.Generic;

namespace FindReversedWords.Tests
{
    [TestClass]
    public class NaiveReversedWordFinderTests
    {
        private IReversedWordFinder reversedWordFinder;

        [TestInitialize]
        public void Initialize()
        {
            reversedWordFinder = new NaiveReversedWordFinder();
        }

        [TestCleanup]
        public void Cleanup()
        {
            reversedWordFinder = null;
        }

        [TestMethod]
        public void EmptyList()
        {
            IEnumerable<string> emptyStringList = new List<string>();
            IEnumerable<ReversedWordPair> emptyReversedWordPairs = new LinkedList<ReversedWordPair>();
            IEnumerable<ReversedWordPair> foundPairs =  reversedWordFinder.FindReversedWords(emptyStringList);
            CollectionAssert.AreEqual(emptyReversedWordPairs.ToList(), foundPairs.ToList());
        }
    }
}
