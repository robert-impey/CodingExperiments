using Shouldly;

namespace LeetCode.Test;

internal static class ListHelpers
{
    public static void OutputListMatches(IList<int> output, IList<int> expected)
    {
        output.Count.ShouldBe(expected.Count);
        
        foreach (var item in expected)
        {
            output.ShouldContain(item);    
        }

        foreach (var item in output)
        {
            expected.ShouldContain(item);
        }
    }

    public static void OutputListMatchesInOrder(int[] output, int[] expected)
    {
        output.Length.ShouldBe(expected.Length);

        for (var i = 0; i < expected.Length; i++)
        {
            output[i].ShouldBe(expected[i]);
        }
    }
}