using Shouldly;

namespace LeetCode.Test;

public class MissingElementsFinderTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 1, 4, 2, 5 };
        var expected = new[] { 3 };

        var solution = new MissingElementsFinder();
        var output = solution.FindMissingElements(input).ToArray();

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 7, 8, 6, 9 };

        var expected = Array.Empty<int>();

        var solution = new MissingElementsFinder();
        var output = solution.FindMissingElements(input).ToArray();

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex3()
    {
        var input = new[] { 5, 1 };
        var expected = new[] { 2, 3, 4 };

        var solution = new MissingElementsFinder();
        var output = solution.FindMissingElements(input).ToArray();

        output.ShouldBe(expected);
    }
}
