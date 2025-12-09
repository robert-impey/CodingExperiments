using Shouldly;

namespace LeetCode.Test;

public class MinOpAryAllDiv3Test
{
    [Fact]
    public void Ex1()
    {
        var nums = new[] { 1, 2, 3, 4 };
        var expected = 3;

        var solution = new MinOpAryAllDiv3();
        var output = solution.MinimumOperations(nums);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var nums = new[] { 3, 6, 9 };
        var expected = 0;

        var solution = new MinOpAryAllDiv3();
        var output = solution.MinimumOperations(nums);

        output.ShouldBe(expected);
    }
}
