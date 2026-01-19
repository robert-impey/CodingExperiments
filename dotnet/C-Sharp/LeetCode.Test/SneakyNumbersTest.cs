namespace LeetCode.Test;

public class SneakyNumbersTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 0, 1, 1, 0 };
        var expected = new[] { 0, 1 };

        var solution = new SneakyNumbers();
        var output = solution.GetSneakyNumbers(input);

        ListHelpers.OutputListMatches(output, expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 0, 3, 2, 1, 3, 2 };
        var expected = new[] { 2, 3 };

        var solution = new SneakyNumbers();
        var output = solution.GetSneakyNumbers(input);

        ListHelpers.OutputListMatches(output, expected);
    }

    [Fact]
    public void Ex3()
    {
        var input = new[] { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 };
        var expected = new[] { 4, 5 };

        var solution = new SneakyNumbers();
        var output = solution.GetSneakyNumbers(input);

        ListHelpers.OutputListMatches(output, expected);
    }
}
