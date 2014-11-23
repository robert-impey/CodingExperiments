using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindReversedWords.Lib
{
    interface IReversedWordFinder
    {
        IEnumerable<string> FindReversedWords(IEnumerable<string> allWords);
    }
}
