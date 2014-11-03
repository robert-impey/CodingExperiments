using System.Collections.Generic;

namespace PalindromeChecker.Lib
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string possiblePalindrome)
        {
            if (string.IsNullOrWhiteSpace(possiblePalindrome))
                return false;

            var tempStack = new Stack<char>();

            var i = 0;
            for (; i < possiblePalindrome.Length / 2; i++)
            {
                tempStack.Push(possiblePalindrome[i]);
            }

            if (possiblePalindrome.Length % 2 == 1)
                i++;

            for (; i < possiblePalindrome.Length; i++)
            {
                if (possiblePalindrome[i] != tempStack.Pop())
                    return false;
            }

            return true;
        }
    }
}
