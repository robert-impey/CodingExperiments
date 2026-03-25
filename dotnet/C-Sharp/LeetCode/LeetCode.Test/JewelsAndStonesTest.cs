using Shouldly;

namespace LeetCode.Test;

public class JewelsAndStonesTest
{
    [Theory]
    [InlineData("aA", "aAAbbbb", 3)]
    [InlineData("z", "ZZ", 0)]
    public void Examples(string jewels, string stones, int expected)
    {
        var sln = new JewelsAndStones();

        sln.NumJewelsInStones(jewels, stones).ShouldBe(expected);
    }
}
