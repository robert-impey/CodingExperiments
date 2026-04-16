using Shouldly;

namespace LeetCode.Test;

public class FindHammingDistanceTest
{
    [Theory]
    [InlineData(1, 4, 2)]
    [InlineData(3, 1, 1)]
    [InlineData(10, 7, 3)]
    [InlineData(3, 4, 3)]
    public void Ex1(int x, int y, int expected)
    {
        var sln = new FindHammingDistance();
        sln.HammingDistance(x, y).ShouldBe(expected);
    }
}
