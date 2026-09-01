// https://leetcode.com/problems/weighted-word-mapping/

namespace LeetCode;

public class WeightedWordMapping
{
    public string MapWordWeights(string[] words, int[] weights)
    {
        ArgumentNullException.ThrowIfNull(words);
        ArgumentNullException.ThrowIfNull(weights);

        var letters = new char[words.Length];

        var aOffSet = (int)'a';
        var zOffSet = (int)'z';

        for (var i = 0; i< words.Length; i++)
        {
            var weight = 0;

            for (var j = 0; j < words[i].Length; j++)
            {
                var c = words[i][j];

                weight += weights[c - aOffSet];
            }

            weight %= weights.Length;

            letters[i] = (char)(zOffSet - weight);
        }

        return new string(letters);
    }
}
