using Shouldly;

namespace LeetCode.Test;

public class GoalParserInterpretationTest
{
    [Theory]
    [InlineData("G()(al)", "Goal")]
    [InlineData("G()()()()(al)", "Gooooal")]
    [InlineData("(al)G(al)()()G", "alGalooG")]
    public void Examples(string s, string expected)
    {
        var sln = new GoalParserInterpretation();

        sln.Interpret(s).ShouldBe(expected);
    }
}
