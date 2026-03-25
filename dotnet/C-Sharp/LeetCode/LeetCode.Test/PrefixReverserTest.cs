using Shouldly;

namespace LeetCode.Test;

public class PrefixReverserTest
{
    [Theory]
    [InlineData("abcd", 2, "bacd")]
    [InlineData("xyz", 3, "zyx")]
    [InlineData("hey", 1, "hey")]
    public void Examples(string s, int k, string expected)
    {
        var sln = new PrefixReverser();

        sln.ReversePrefix(s, k).ShouldBe(expected);
    }
}
