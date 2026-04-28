using Shouldly;

namespace LeetCode.Test;

public class EmployeesWhoMetTargetTest
{
    [Fact]
    public void Ex1()
    {
        var hours = new[] { 0, 1, 2, 3, 4 };

        var solution = new EmployeesWhoMetTarget();
        var result = solution.NumberOfEmployeesWhoMetTarget(hours, 2);

        result.ShouldBe(3);
    }

    [Fact]
    public void Ex2()
    {
        var hours = new[] { 5, 1, 4, 2, 2 };

        var solution = new EmployeesWhoMetTarget();
        var result = solution.NumberOfEmployeesWhoMetTarget(hours, 6);

        result.ShouldBe(0);
    }
}
