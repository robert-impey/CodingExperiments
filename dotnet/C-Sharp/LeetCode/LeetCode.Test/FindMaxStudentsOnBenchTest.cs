using Shouldly;

namespace LeetCode.Test;

public class FindMaxStudentsOnBenchTest
{
    [Fact]
    public void Ex1()
    {
        // Input: students = [[1,2],[2,2],[3,3],[1,3],[2,3]]
        var students = new[]
        {
            new[] {1, 2 },
            new[] {2, 2 },
            new[] {3, 3 },
            new[] {1, 3 },
            new[] {2, 3 },
            new[] { 2, 3 }
        };

        var solution = new FindMaxStudentsOnBench();
        var result = solution.MaxStudentsOnBench(students);

        // Output: 3
        result.ShouldBe(3);
    }

    [Fact]
    public void Ex2()
    {
        // Input: students = [[1, 1], [2, 1], [3, 1], [4, 2], [5, 2]]
        var students = new[]
        {
            new[] {1, 2 },
            new[] {2, 1 },
            new[] {3, 1 },
            new[] {4, 2 },
            new[] {5, 2 }
        };

        var solution = new FindMaxStudentsOnBench();
        var result = solution.MaxStudentsOnBench(students);

        // Output: 3
        result.ShouldBe(3);
    }

    [Fact]
    public void Ex3()
    {
        // Input: students = [[1,1],[1,1]]
        var students = new[]
                {
            new[] {1, 1 },
            new[] {1, 1 }
        };

        var solution = new FindMaxStudentsOnBench();
        var result = solution.MaxStudentsOnBench(students);

        // Output: 1
        result.ShouldBe(1);
    }

    [Fact]
    public void Ex4()
    {
        // Input: students = []
        var students = Array.Empty<int[]>();

        var solution = new FindMaxStudentsOnBench();
        var result = solution.MaxStudentsOnBench(students);

        // Output: 0
        result.ShouldBe(0);
    }
}
