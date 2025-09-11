using Shouldly;

namespace RemoveVowelsFromAString.Test;

public class RemoveVowelsFromAStringTest
{
    [Theory]
    [InlineData("aeiou", "")]
    [InlineData("leetcodeisacommunityforcoders", "ltcdscmmntyfrcdrs")]
    public void Examples(string input, string expected)
    {        
        var sln = new Solution();
        
        sln.RemoveVowels(input).ShouldBe(expected);
    }
}
