using Shouldly;

namespace LeetCode.Test;

public class MinOpArySumDivKTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 3, 9, 7};
        var k = 5;
        var expected = 4;

        var solution = new MinOpArySumDivK();
        var output = solution.MinOperations(input, k);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 4, 1, 3 };
        var k = 4;
        var expected = 0;

        var solution = new MinOpArySumDivK();
        var output = solution.MinOperations(input, k);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex3()
    {
        var input = new[] { 3, 2 };
        var k = 6;
        var expected = 5;

        var solution = new MinOpArySumDivK();
        var output = solution.MinOperations(input, k);

        output.ShouldBe(expected);
    }
}
