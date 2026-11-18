using Shouldly;

namespace LeetCode.Test;

public class LargestLocalFinderTest
{
    [Fact]
    public void Ex1()
    {
        var input = new int[][]
        {
            [9,9,8,1],
            [5,6,2,6],
            [8,2,6,4],
            [6,2,2,2]
        };

        var expected = new int[][]
        {
           [9,9],
           [8,6]
        };

        var solution = new LargestLocalFinder();
        var output = solution.LargestLocal(input);

        output.ShouldBe(expected);
    }

    [Fact]
    public void Ex2()
    {
        var input = new int[][]
        {
            [1,1,1,1,1],
            [1,1,1,1,1],
            [1,1,2,1,1],
            [1,1,1,1,1],
            [1,1,1,1,1]
        };

        var expected = new int[][]
        {
           [2,2,2],
           [2,2,2],
           [2,2,2]
        };

        var solution = new LargestLocalFinder();
        var output = solution.LargestLocal(input);

        output.ShouldBe(expected);
    }
}
