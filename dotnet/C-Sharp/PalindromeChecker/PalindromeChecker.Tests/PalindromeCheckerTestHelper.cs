using PalindromeChecker.Lib;

namespace PalindromeChecker.Tests;

internal static class PalindromeCheckerTestHelper
{
    public static void TestPalindromeChecker(IPalindromeChecker palindromeChecker)
    {
        Assert.False(palindromeChecker.IsPalindrome(""));
        Assert.True(palindromeChecker.IsPalindrome("a"));
        Assert.True(palindromeChecker.IsPalindrome("aa"));
        Assert.False(palindromeChecker.IsPalindrome("ab"));
        Assert.True(palindromeChecker.IsPalindrome("aba"));
        Assert.True(palindromeChecker.IsPalindrome("abba"));
        Assert.False(palindromeChecker.IsPalindrome("abab"));
    }
}
