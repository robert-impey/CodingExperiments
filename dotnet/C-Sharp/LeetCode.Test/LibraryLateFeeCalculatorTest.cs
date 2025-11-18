using Shouldly;

namespace LeetCode.Test;

public class LibraryLateFeeCalculatorTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 5, 1, 7};
        var expected = 32;

        var solution = new LibraryLateFeeCalculator();
        var output = solution.LateFee(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 1, 1 };
        var expected = 2;

        var solution = new LibraryLateFeeCalculator();
        var output = solution.LateFee(input);

        output.ShouldBe(expected);
    }
}
