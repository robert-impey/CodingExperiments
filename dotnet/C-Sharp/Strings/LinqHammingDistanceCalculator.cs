namespace Strings;

public class LinqHammingDistanceCalculator : HammingDistanceCalculator
{
    public override int? CalculateDistance(string a, string b)
    {
        if (a.Length != b.Length || a.Length == 0)
            return null;

        return a.Where((t, i) => t != b[i]).Count();
    }
}