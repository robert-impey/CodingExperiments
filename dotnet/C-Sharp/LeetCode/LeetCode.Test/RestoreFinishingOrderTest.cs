using Shouldly;

namespace LeetCode.Test;

public class RestoreFinishingOrderTest
{
    [Fact]
    public void Ex1()
    {
        var order = new[] { 3, 1, 2, 5, 4 };
        var friends = new[] { 1, 3, 4 };
        var expected = new[] { 3, 1, 4 };

        var solution = new RestoreFinishingOrder();
        var output = solution.RecoverOrder(order, friends);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var order = new[] { 1, 4, 5, 3, 2 };
        var friends = new[] { 2, 5 };
        var expected = new[] { 5, 2 };

        var solution = new RestoreFinishingOrder();
        var output = solution.RecoverOrder(order, friends);

        output.ShouldBe(expected);
    }
}
