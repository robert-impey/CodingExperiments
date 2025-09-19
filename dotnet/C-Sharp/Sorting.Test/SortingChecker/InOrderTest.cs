using Shouldly;
using Xunit;

namespace Sorting.Test.SortingChecker;

public class InOrderTest
{
    [Fact]
    public void TestEmpty()
    {
        Lib.SortingChecker.IsInOrder([]).ShouldBeTrue();
    }

    [Fact]
    public void TestSingle()
    {
        Lib.SortingChecker.IsInOrder([1]).ShouldBeTrue();
    }

    [Fact]
    public void TestAscending()
    {
        Lib.SortingChecker.IsInOrder([1, 2, 3]).ShouldBeTrue();
    }

    [Fact]
    public void TestRepeated()
    {
        Lib.SortingChecker.IsInOrder([1, 1, 1]).ShouldBeTrue();
    }

    [Fact]
    public void TestOutOfOrder()
    {
        Lib.SortingChecker.IsInOrder([2, 1, 3]).ShouldBeFalse();
    }
}