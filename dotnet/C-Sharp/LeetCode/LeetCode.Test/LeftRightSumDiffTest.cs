using Shouldly;

namespace LeetCode.Test;

public class LeftRightSumDiffTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 10, 4, 8, 3 };
        var expected = new[] { 15, 1, 11, 22 };

        var solution = new LeftRightSumDiff();
        var output = solution.LeftRightDifference(input);

        output.ShouldBe(expected, ignoreOrder: true);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 1 };
        var expected = new[] { 0 };

        var solution = new LeftRightSumDiff();
        var output = solution.LeftRightDifference(input);

        output.ShouldBe(expected, ignoreOrder: true);
    }
}
