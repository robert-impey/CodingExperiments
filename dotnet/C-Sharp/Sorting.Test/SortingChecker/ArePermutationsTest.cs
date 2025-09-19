using Shouldly;
using Xunit;

namespace Sorting.Test.SortingChecker;

public class ArePermutationsTest
{
    [Fact]
    public void EmptyArrays()
    {
        Lib.SortingChecker.ArePermutations([], []).ShouldBeTrue();
    }

    [Fact]
    public void SingleSameElement()
    {
        Lib.SortingChecker.ArePermutations([1], [1]).ShouldBeTrue();
    }

    [Fact]
    public void SingleDifferentElement()
    {
        Lib.SortingChecker.ArePermutations([1], [2]).ShouldBeFalse();
    }

    [Fact]
    public void DifferentLength()
    {
        Lib.SortingChecker.ArePermutations([1], []).ShouldBeFalse();
    }

    [Fact]
    public void SameElementsDifferentOrder()
    {
        Lib.SortingChecker.ArePermutations([1, 2, 3], [2, 1, 3]).ShouldBeTrue();
    }

    [Fact]
    public void NullsAreDifferent()
    {
        Lib.SortingChecker.ArePermutations(null, null).ShouldBeFalse();
    }

    [Fact]
    public void InputsAreNotChanged()
    {
        var input1 = new int[] { 2, 3, 1 };
        var input2 = new int[] { 3, 1, 2 };

        Lib.SortingChecker.ArePermutations(input1, input2);

        input1[0].ShouldBe(2);
        input1[1].ShouldBe(3);
        input1[2].ShouldBe(1);

        input2[0].ShouldBe(3);
        input2[1].ShouldBe(1);
        input2[2].ShouldBe(2);
    }
}