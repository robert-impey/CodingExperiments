namespace LeetCode.Test;

public class KidsWithGreatestCandiesTest
{
    [Fact]
    public void Ex1()
    {
        var candies = new[] { 2, 3, 5, 1, 3 };
        var extraCandies = 3;
        var expected = new[] { true, true, true, false, true };

        var solution = new KidsWithGreatestCandies();
        var output = solution.KidsWithCandies(candies, extraCandies);

        ListHelpers.MatchesInOrder(output, expected);
    }

    [Fact]
    public void Ex2()
    {
        var candies = new[] { 4, 2, 1, 1, 2 };
        var extraCandies = 1;
        var expected = new[] { true, false, false, false, false };

        var solution = new KidsWithGreatestCandies();
        var output = solution.KidsWithCandies(candies, extraCandies);

        ListHelpers.MatchesInOrder(output, expected);
    }

    [Fact]
    public void Ex3()
    {
        var candies = new[] { 12, 1, 12 };
        var extraCandies = 10;
        var expected = new[] { true, false, true };

        var solution = new KidsWithGreatestCandies();
        var output = solution.KidsWithCandies(candies, extraCandies);

        ListHelpers.MatchesInOrder(output, expected);
    }
}
