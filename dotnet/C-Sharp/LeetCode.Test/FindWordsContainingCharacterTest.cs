using Shouldly;

namespace LeetCode.Test;

public class FindWordsContainingCharacterTest
{
    [Fact]
    public void Ex1()
    {
        var words = new [] {"leet", "code"};
        const char x = 'e';
        
        var expected = new[] { 0, 1 };
        
        ListTest(words, x, expected);
    }

    [Fact]
    public void Ex2()
    {
        var words = new [] {"abc","bcd","aaaa","cbc"};
        const char x = 'a';
        
        var expected = new[] { 0,2 };
        
        ListTest(words, x, expected);
    }

    [Fact]
    public void Ex3()
    {
        var words = new [] {"abc","bcd","aaaa","cbc"};
        const char x = 'z';
        
        var sln = new FindWordsContainingCharacter();
        var outcome = sln.FindWordsContaining(words, x);
        
        outcome.ShouldBeEmpty();
    }

    private static void ListTest(string[] words, char x, IList<int> expected)
    {
        var sln = new FindWordsContainingCharacter();
        var outcome = sln.FindWordsContaining(words, x);

        ListHelpers.OutcomeListMatches(outcome, expected);
    }
}