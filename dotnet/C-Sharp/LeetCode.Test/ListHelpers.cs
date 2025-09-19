using Shouldly;

namespace LeetCode.Test;

internal static class ListHelpers
{
    public static void OutcomeListMatches(IList<int> outcome, IList<int> expected)
    {
        outcome.Count.ShouldBe(expected.Count);
        
        foreach (var item in expected)
        {
            outcome.ShouldContain(item);    
        }

        foreach (var item in outcome)
        {
            expected.ShouldContain(item);
        }
    }
}