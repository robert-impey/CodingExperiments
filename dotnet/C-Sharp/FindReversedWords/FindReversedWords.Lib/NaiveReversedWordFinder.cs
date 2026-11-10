using System.Collections.Generic;
using System.Linq;

namespace FindReversedWords.Lib
{
    public class NaiveReversedWordFinder : IReversedWordFinder
    {
        private readonly IReversedStringChecker _reversedStringChecker;

        public NaiveReversedWordFinder(IReversedStringChecker reversedStringChecker)
        {
            _reversedStringChecker = reversedStringChecker;
        }

        public IEnumerable<ReversedWordPair> FindReversedWords(IQueryable<string> allWords)
        {
            var reversedWords = new LinkedList<ReversedWordPair>();

            foreach (var firstWord in allWords)
            {
                foreach (var secondWord in allWords)
                {
                    if (_reversedStringChecker.AreReversedPair(firstWord, secondWord))
                    {
                        reversedWords.AddLast(new ReversedWordPair(firstWord, secondWord));
                    }
                }
            }

            return reversedWords;
        }
    }
}
