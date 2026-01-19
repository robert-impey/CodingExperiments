namespace LeetCode.Test;

public class ShuffleArrayTest
{
    [Fact]
    public void Ex1()
    {
        var input = new[] { 2, 5, 1, 3, 4, 7 };
        var expected = new[] { 2, 3, 5, 4, 1, 7 };

        var solution = new ShuffleArray();
        var output = solution.Shuffle(input, input.Length / 2);

        ListHelpers.OutputListMatchesInOrder(output, expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new[] { 1, 2, 3, 4, 4, 3, 2, 1 };
        var expected = new[] { 1, 4, 2, 3, 3, 2, 4, 1 };

        var solution = new ShuffleArray();
        var output = solution.Shuffle(input, input.Length / 2);

        ListHelpers.OutputListMatchesInOrder(output, expected);
    }

    [Fact]
    public void Ex3()
    {
        var input = new[] { 1, 1, 2, 2 };
        var expected = new[] { 1, 2, 1, 2 };

        var solution = new ShuffleArray();
        var output = solution.Shuffle(input, input.Length / 2);

        ListHelpers.OutputListMatchesInOrder(output, expected);
    }
}
