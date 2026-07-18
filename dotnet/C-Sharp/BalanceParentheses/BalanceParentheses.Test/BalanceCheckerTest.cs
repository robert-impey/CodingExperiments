using BalanceParentheses.Lib;
using Shouldly;

namespace BalanceParentheses.Test;

public class BalanceCheckerTest
{
    [Theory]
    [InlineData("", true)]
    [InlineData("()", true)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    [InlineData("(())", true)]
    [InlineData("(()())", true)]
    [InlineData("(foo)(bar)", true)]
    [InlineData("(()", false)]
    [InlineData(")(", false)]
    public void IsStringBalanced(string input, bool expected)
    {
        BalanceChecker.IsStringBalanced(input).ShouldBe(expected);
    }
}
