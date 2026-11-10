using System.Collections.Generic;

namespace FindReversedWords.Lib
{
    public class StackReversedStringChecker : IReversedStringChecker
    {
        public bool AreReversedPair(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }

            var firstStringStack = new Stack<char>();

            foreach (var c in firstString)
            {
                firstStringStack.Push(c);
            }

            foreach (var currentCharFromSecond in secondString)
            {
                var currentCharFromFirst = firstStringStack.Pop();

                if (currentCharFromFirst != currentCharFromSecond)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
