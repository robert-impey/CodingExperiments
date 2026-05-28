using Shouldly;

namespace LeetCode.Test;

public class CountPairsSumLessThanTargetTest
{
    [Fact]
    public void Ex1()
    {
        var nums = new[] { -1, 1, 2, 3, 1 };

        var solution = new CountPairsSumLessThanTarget();
        var result = solution.CountPairs(nums, 2);

        result.ShouldBe(3);
    }

    [Fact]
    public void Ex2()
    {
        var nums = new[] { -6, 2, 5, -2, -7, -1, 3 };

        var solution = new CountPairsSumLessThanTarget();
        var result = solution.CountPairs(nums, -2);

        result.ShouldBe(10);
    }
}
