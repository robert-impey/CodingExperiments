using Shouldly;

namespace LeetCode.Test;

public class FinalValueAfterPerformingOperationsTest
{
    [Fact]
    public void Ex1()
    {
        var oparations = new[] { "--X", "X++", "X++" };
        var expected = 1;

        var solution = new FinalValueAfterPerformingOperations();
        var output = solution.FinalValueAfterOperations(oparations);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var oparations = new[] { "++X", "++X", "X++" };
        var expected = 3;

        var solution = new FinalValueAfterPerformingOperations();
        var output = solution.FinalValueAfterOperations(oparations);

        output.ShouldBe(expected);
    }
}
