using Shouldly;

namespace BuildArrayFromPermutation.Test;

public class SolutionTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 0, 2, 1, 5, 3, 4 };
        var expected = new[] { 0, 1, 2, 4, 5, 3 };

        var solution = new Solution();
        var output = solution.BuildArray(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 5, 0, 1, 2, 3, 4 };
        var expected = new[] { 4, 5, 0, 1, 2, 3 };

        var solution = new Solution();
        var output = solution.BuildArray(input);

        output.ShouldBe(expected);
    }
}