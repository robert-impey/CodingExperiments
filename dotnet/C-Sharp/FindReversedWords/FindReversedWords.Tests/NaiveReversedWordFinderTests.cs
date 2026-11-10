using FindReversedWords.Lib;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FindReversedWords.Tests
{
    public class NaiveReversedWordFinderTests
    {
        private readonly IReversedWordFinder reversedWordFinder = new NaiveReversedWordFinder(
            new StackReversedStringChecker());
        private readonly IQueryable<string> emptyStringList = new List<string>().AsQueryable();
        private readonly IEnumerable<string> wordsWithoutReversedWords = new[] { "apple", "banana", "coconut" };
        private readonly IEnumerable<string> wordsWithReversedWords = new[] { "note", "eton", "tone" };
        private readonly IEnumerable<string> wordsWithPalindrone = new[] { "noon" };

        [Fact]
        public void EmptyList()
        {
            var foundPairs = FindPairs(emptyStringList);
            Assert.Empty(foundPairs);
        }

        [Fact]
        public void ListWithoutReversedWords()
        {
            var foundPairs = FindPairs(wordsWithoutReversedWords);
            Assert.Empty(foundPairs);
        }

        [Fact]
        public void ListWithReversedWords()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithReversedWords);
            Assert.Contains(new ReversedWordPair("eton", "note"), foundPairs);
        }

        [Fact]
        public void ListWithReversedWordsReverseOrder()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithReversedWords);
            Assert.Contains(new ReversedWordPair("note", "eton"), foundPairs);
        }

        [Fact]
        public void ListWithReversedWordsCount()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithReversedWords);
            Assert.Equal(2, foundPairs.Count());
        }

        [Fact]
        public void ListWithPalindroneItem()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithPalindrone);
            Assert.Contains(new ReversedWordPair("noon", "noon"), foundPairs);
        }

        [Fact]
        public void ListWithPalindroneCount()
        {
            IEnumerable<ReversedWordPair> foundPairs = FindPairs(wordsWithPalindrone);
            Assert.Single(foundPairs);
        }

        private IEnumerable<ReversedWordPair> FindPairs(IEnumerable<string> words)
        {
            return reversedWordFinder.FindReversedWords(words.AsQueryable());
        }
    }
}
