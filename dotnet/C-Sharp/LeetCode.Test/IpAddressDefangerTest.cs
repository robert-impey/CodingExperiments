using Shouldly;

namespace LeetCode.Test;

public class IpAddressDefangerTest
{
    [Fact]
    public void Ex1()
    {
        var input = "1.1.1.1";
        var expected = "1[.]1[.]1[.]1";

        var solution = new IpAddressDefanger();
        var output = solution.DefangIPaddr(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = "255.100.50.0";
        var expected = "255[.]100[.]50[.]0";

        var solution = new IpAddressDefanger();
        var output = solution.DefangIPaddr(input);

        output.ShouldBe(expected);
    }
}
