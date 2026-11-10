using FindReversedWords.Lib;
using Xunit;

namespace FindReversedWords.Tests
{
    public class StackReversedStringCheckerTests
    {
        private readonly IReversedStringChecker reversedStringChecker = new StackReversedStringChecker();

        [Fact]
        public void EmptyStrings()
        {
            Assert.True(reversedStringChecker.AreReversedPair(string.Empty, string.Empty));
        }

        [Fact]
        public void SameSingleCharStrings()
        {
            Assert.True(reversedStringChecker.AreReversedPair("a", "a"));
        }

        [Fact]
        public void DifferentSingleCharStrings()
        {
            Assert.False(reversedStringChecker.AreReversedPair("a", "b"));
        }

        [Fact]
        public void SameMultiCharStrings()
        {
            Assert.False(reversedStringChecker.AreReversedPair("ab", "ab"));
        }

        [Fact]
        public void ReversedMultiCharsStrings()
        {
            Assert.True(reversedStringChecker.AreReversedPair("ab", "ba"));
        }

        [Fact]
        public void ReversedMultiCharsStringsWithExtraChar()
        {
            Assert.False(reversedStringChecker.AreReversedPair("ab", "baa"));
        }
    }
}
