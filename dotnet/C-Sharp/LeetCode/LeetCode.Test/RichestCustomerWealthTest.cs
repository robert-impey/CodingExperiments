using Shouldly;

namespace LeetCode.Test;

public class RichestCustomerWealthTest
{
    [Fact]
    public void Ex1()
    {
        var input = new int[][] { [1, 2, 3], [3, 2, 1] };
        var expected = 6;

        var solution = new RichestCustomerWealth();
        var output = solution.MaximumWealth(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new int[][] { [1, 5], [7, 3], [3, 5] };
        var expected = 10;

        var solution = new RichestCustomerWealth();
        var output = solution.MaximumWealth(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex3()
    {
        var input = new int[][] { [2, 8, 7], [7, 1, 3], [1, 9, 5] };
        var expected = 17;

        var solution = new RichestCustomerWealth();
        var output = solution.MaximumWealth(input);

        output.ShouldBe(expected);
    }
}
