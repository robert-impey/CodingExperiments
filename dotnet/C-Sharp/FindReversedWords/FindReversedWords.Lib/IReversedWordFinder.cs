using System.Collections.Generic;
using System.Linq;

namespace FindReversedWords.Lib
{
    public interface IReversedWordFinder
    {
        IEnumerable<ReversedWordPair> FindReversedWords(IQueryable<string> allWords);
    }
}
