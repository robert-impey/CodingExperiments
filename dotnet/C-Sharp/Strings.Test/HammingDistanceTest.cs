using Shouldly;

namespace Strings.Test;

public class HammingDistanceTest
{
    [Fact]
    public void Same()
    {
        HammingDistance.Distance("abc", "abc").ShouldBe(0);
    }

    [Fact]
    public void Empty()
    {
        HammingDistance.Distance(string.Empty, string.Empty).ShouldBeNull();
    }

    [Fact]
    public void DifferentLength()
    {
        HammingDistance.Distance("a", "ab").ShouldBeNull();
    }

    [Fact]
    public void KarolinKathrin()
    {
        HammingDistance.Distance("karolin", "kathrin").ShouldBe(3);
    }
}