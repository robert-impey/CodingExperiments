namespace LeetCode.Test;

public class TransformArrayByParityTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 4, 3, 2, 1 };
        var expected = new[] { 0, 0, 1, 1 };

        var solution = new TransformArrayByParity();
        var output = solution.TransformArray(input);

        ListHelpers.OutcomeListMatches(expected, output);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 1, 5, 1, 4, 2 };
        var expected = new[] { 0, 0, 1, 1, 1 };

        var solution = new TransformArrayByParity();
        var output = solution.TransformArray(input);

        ListHelpers.OutcomeListMatches(expected, output);
    }
}
