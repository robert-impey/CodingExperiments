namespace PalindromeChecker.Lib;

public class IndexPalindromeChecker : IPalindromeChecker
{
    public bool IsPalindrome(string possiblePalindrome)
    {
        if (string.IsNullOrWhiteSpace(possiblePalindrome))
            return false;

        var i = 0;
        for (; i < possiblePalindrome.Length / 2; i++)
        {
            if (possiblePalindrome[i] != possiblePalindrome[possiblePalindrome.Length - i - 1])
                return false;
        }

        return true;
    }
}
