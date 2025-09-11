namespace RemoveVowelsFromAString;

public class Solution
{
    public string RemoveVowels(string s)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        var result = new System.Text.StringBuilder();

        foreach (var ch in s)
        {
            if (!vowels.Contains(ch))
            {
                result.Append(ch);
            }
        }

        return result.ToString();
    }
}