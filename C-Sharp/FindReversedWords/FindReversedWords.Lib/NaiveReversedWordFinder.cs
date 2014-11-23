using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindReversedWords.Lib
{
    public class NaiveReversedWordFinder : IReversedWordFinder
    {
        public IEnumerable<ReversedWordPair> FindReversedWords(IEnumerable<string> allWords)
        {
            var reversedWords = new LinkedList<ReversedWordPair>();

            return reversedWords;
        }
    }
}
