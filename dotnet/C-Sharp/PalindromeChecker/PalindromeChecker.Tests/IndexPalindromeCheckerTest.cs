using PalindromeChecker.Lib;

namespace PalindromeChecker.Tests;

public class IndexPalindromeCheckerTest
{
    [Fact]
    public void TestPalindromeChecker()
    {
        PalindromeCheckerTestHelper.TestPalindromeChecker(new IndexPalindromeChecker());
    }
}
