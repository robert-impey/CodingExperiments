namespace Strings;

public class JumpsHammingDistanceCalculator : HammingDistanceCalculator
{
    public override int? CalculateDistance(string a, string b)
    {
        if (a.Length != b.Length || a.Length == 0)
            return null;

        var distance = 0;

        for (var i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                distance++;
        }
        
        return distance;
    }
}