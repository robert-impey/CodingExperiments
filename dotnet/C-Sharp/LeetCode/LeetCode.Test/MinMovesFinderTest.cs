using Shouldly;

namespace LeetCode.Test;

public class MinMovesFinderTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 2, 1, 3 };
        var expected = 3;

        var solution = new MinMovesFinder();
        var output = solution.MinMoves(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 4, 4, 5 };
        var expected = 2;

        var solution = new MinMovesFinder();
        var output = solution.MinMoves(input);

        output.ShouldBe(expected);
    }
}
