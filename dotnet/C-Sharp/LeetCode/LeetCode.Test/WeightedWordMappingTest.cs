using Shouldly;

namespace LeetCode.Test;

public class WeightedWordMappingTest
{
    [Fact]
    public void Ex1()
    {
        var words = new[] { "abcd", "def", "xyz" };
        var weights = new[] { 5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2 };

        var sln = new WeightedWordMapping();
        var output = sln.MapWordWeights(words, weights);
        output.ShouldBe("rij");
    }

    [Fact]
    public void Ex2()
    {
        var words = new[] { "a", "b", "c" };
        var weights = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        var sln = new WeightedWordMapping();
        var output = sln.MapWordWeights(words, weights);
        output.ShouldBe("yyy");
    }

    [Fact]
    public void Ex3()
    {
        var words = new[] { "abcd" };
        var weights = new[] { 7, 5, 3, 4, 3, 5, 4, 9, 4, 2, 2, 7, 10, 2, 5, 10, 6, 1, 2, 2, 4, 1, 3, 4, 4, 5 };

        var sln = new WeightedWordMapping();
        var output = sln.MapWordWeights(words, weights);
        output.ShouldBe("g");
    }
}
