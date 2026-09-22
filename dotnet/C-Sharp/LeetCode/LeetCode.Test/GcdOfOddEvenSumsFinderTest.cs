using Shouldly;

namespace LeetCode.Test;

public class GcdOfOddEvenSumsFinderTest
{
    private readonly GcdOfOddEvenSumsFinder _solution = new();

    [Theory]
    [InlineData(4, 4)]
    [InlineData(5, 5)]
    public void Ex(int n, int expected)
    {
        _solution.GcdOfOddEvenSums(n).ShouldBe(expected);
    }
}
