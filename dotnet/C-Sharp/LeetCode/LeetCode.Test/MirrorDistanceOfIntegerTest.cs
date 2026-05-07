using Shouldly;

namespace LeetCode.Test;

public class MirrorDistanceOfIntegerTest
{
    private readonly MirrorDistanceOfInteger _solution = new();

    [Theory]
    [InlineData(25, 27)]
    [InlineData(10, 9)]
    [InlineData(7, 0)]
    public void Ex(int n, int expected)
    {
        _solution.MirrorDistance(n).ShouldBe(expected);
    }

    [Theory]
    [InlineData(7, 7)]
    [InlineData(10, 1)]
    [InlineData(25, 52)]
    [InlineData(1_002_000, 2001)]
    [InlineData(1, 1)]
    [InlineData(1_000_000_000, 1)]
    [InlineData(123456789, 987654321)]
    public void Reverse(int n, int expected)
    {
        MirrorDistanceOfInteger.Reverse(n).ShouldBe(expected);
    }
}
