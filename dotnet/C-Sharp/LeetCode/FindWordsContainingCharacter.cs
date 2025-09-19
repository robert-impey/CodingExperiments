// https://leetcode.com/problems/find-words-containing-character

namespace LeetCode;

public class FindWordsContainingCharacter
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var indexes = new HashSet<int>();

        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                indexes.Add(i);
            }
        }
        
        return indexes.ToList();
    }
}