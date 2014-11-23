using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindReversedWords.Lib
{
    public interface IReversedStringChecker
    {
        bool AreReversedPair(string firstString, string secondString);
    }
}
