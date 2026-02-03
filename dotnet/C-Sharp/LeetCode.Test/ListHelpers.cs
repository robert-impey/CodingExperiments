using Shouldly;

namespace LeetCode.Test;

internal static class ListHelpers
{
    public static void OutputListContent(IList<int> output, IList<int> expected)
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

    public static void MatchesInOrder<T>(IList<T> output, IList<T> expected)
    {
        if (expected is null)
        {
            Assert.NotNull(output);
        }
        else
        {
            if (output is null)
            {
                Assert.Fail("Expected is not null but the output is!");
            }
            else
            {
                output.Count.ShouldBe(expected.Count);

                for (var i = 0; i < expected.Count; i++)
                {
                    output[i].ShouldBe(expected[i]);
                }
            }
        }
    }
}