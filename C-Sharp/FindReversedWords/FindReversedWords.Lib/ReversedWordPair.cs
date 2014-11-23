using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindReversedWords.Lib
{
    public class ReversedWordPair
    {
        private readonly string firstWord;
        public string FirstWord { get { return firstWord; } }

        private readonly string secondWord;
        public string SecondWord { get { return secondWord; } }

        public ReversedWordPair(string firstWord, string secondWord)
        {
            this.firstWord = firstWord;
            this.secondWord = secondWord;
        }
    }
}
