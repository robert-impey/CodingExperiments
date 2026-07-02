using Shouldly;

namespace LeetCode.Test;

public class IntegerExtensionsTest
{
    [Fact]
    public void Zero()
    {
        var digits = 0.ToDigits(1);

        digits.ShouldNotBeNull();
        digits.Length.ShouldBe(1);
        digits[0].ShouldBe(0);
    }

    [Fact]
    public void Ascending()
    {
        var digits = 1234.ToDigits(4);

        digits.ShouldNotBeNull();
        digits.Length.ShouldBe(4);
        digits[0].ShouldBe(1);
        digits[1].ShouldBe(2);
        digits[2].ShouldBe(3);
        digits[3].ShouldBe(4);
    }

    [Fact]
    public void AllSame()
    {
        var digits = 555.ToDigits(3);

        digits.ShouldNotBeNull();
        digits.Length.ShouldBe(3);
        digits[0].ShouldBe(5);
        digits[1].ShouldBe(5);
        digits[2].ShouldBe(5);
    }
}
