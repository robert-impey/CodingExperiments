using Shouldly;

namespace LeetCode.Test;

public class NumberOfGoodPairsTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 1, 2, 3, 1, 1, 3 };
        var expected = 4;

        var solution = new NumberOfGoodPairs();
        var output = solution.NumIdenticalPairs(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 1, 1, 1, 1 };
        var expected = 6;

        var solution = new NumberOfGoodPairs();
        var output = solution.NumIdenticalPairs(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex3()
    {
        var input = new[] { 1, 2, 3 };
        var expected = 0;

        var solution = new NumberOfGoodPairs();
        var output = solution.NumIdenticalPairs(input);

        output.ShouldBe(expected);
    }
}
