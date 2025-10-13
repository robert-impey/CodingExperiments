using Shouldly;

namespace Strings.Test;

public abstract class HammingDistanceCalculatorTest(HammingDistanceCalculator calculator)
{
    [Fact]
    public void Same()
    {
        calculator.CalculateDistance("abc", "abc").ShouldBe(0);
    }

    [Fact]
    public void Empty()
    {
        calculator.CalculateDistance(string.Empty, string.Empty).ShouldBeNull();
    }

    [Fact]
    public void DifferentLength()
    {
        calculator.CalculateDistance("a", "ab").ShouldBeNull();
    }

    [Fact]
    public void KarolinKathrin()
    {
        calculator.CalculateDistance("karolin", "kathrin").ShouldBe(3);
    }
}