using Shouldly;

namespace LeetCode.Test;

public class MinDigitSumElementTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 10, 12, 13, 14 };
        var expected = 1;

        var solution = new MinDigitSumElement();
        var output = solution.MinElement(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 1, 2, 3, 4 };
        var expected = 1;

        var solution = new MinDigitSumElement();
        var output = solution.MinElement(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex3()
    {
        var input = new[] { 999, 19, 199 };
        var expected = 10;

        var solution = new MinDigitSumElement();
        var output = solution.MinElement(input);

        output.ShouldBe(expected);
    }
}
