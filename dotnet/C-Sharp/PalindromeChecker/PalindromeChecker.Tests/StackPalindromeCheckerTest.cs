using PalindromeChecker.Lib;

namespace PalindromeChecker.Tests;

public class StackPalindromeCheckerTest
{
    [Fact]
    public void TestPalindromeChecker()
    {
        PalindromeCheckerTestHelper.TestPalindromeChecker(new StackPalindromeChecker());
    }
}
