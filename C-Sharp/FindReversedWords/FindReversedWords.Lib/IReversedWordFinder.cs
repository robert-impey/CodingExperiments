using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindReversedWords.Lib
{
    public interface IReversedWordFinder
    {
        IEnumerable<ReversedWordPair> FindReversedWords(IQueryable<string> allWords);
    }
}
