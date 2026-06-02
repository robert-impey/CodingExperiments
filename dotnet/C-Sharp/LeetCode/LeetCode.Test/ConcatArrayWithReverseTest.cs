namespace LeetCode.Test;

public class ConcatArrayWithReverseTest
{
    [Fact]
    public void Ex1()
    {
        var nums = new[] { 1, 2, 3 };
        var expected = new[] { 1, 2, 3, 3, 2, 1 };

        var solution = new ConcatArrayWithReverse();
        var output = solution.ConcatWithReverse(nums);

        ListHelpers.MatchesInOrder(output, expected);
    }

    [Fact]
    public void Ex2()
    {
        var nums = new[] { 1 };
        var expected = new[] { 1, 1 };

        var solution = new ConcatArrayWithReverse();
        var output = solution.ConcatWithReverse(nums);

        ListHelpers.MatchesInOrder(output, expected);
    }
}
