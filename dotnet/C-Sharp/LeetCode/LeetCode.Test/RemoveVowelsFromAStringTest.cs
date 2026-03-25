using Shouldly;

namespace LeetCode.Test;

public class RemoveVowelsFromAStringTest
{
    [Theory]
    [InlineData("aeiou", "")]
    [InlineData("leetcodeisacommunityforcoders", "ltcdscmmntyfrcdrs")]
    public void Examples(string input, string expected)
    {        
        var sln = new RemoveVowelsFromAString();
        
        sln.RemoveVowels(input).ShouldBe(expected);
    }
}
