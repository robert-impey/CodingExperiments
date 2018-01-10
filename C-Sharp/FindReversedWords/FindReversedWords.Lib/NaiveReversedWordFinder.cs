using System.Collections.Generic;
using System.Linq;

namespace FindReversedWords.Lib
{
    public class NaiveReversedWordFinder : IReversedWordFinder
    {
        public IEnumerable<ReversedWordPair> FindReversedWords(IQueryable<string> allWords)
        {
            var reversedWords = new LinkedList<ReversedWordPair>();
            var reversedStringChecker = new StackReversedStringChecker();

            foreach (var firstWord in allWords)
            {
                foreach (var secondWord in allWords)
                {
                    if (reversedStringChecker.AreReversedPair(firstWord, secondWord))
                    {
                        reversedWords.AddLast(new ReversedWordPair(firstWord, secondWord));
                    }
                }
            }

            return reversedWords;
        }
    }
}
