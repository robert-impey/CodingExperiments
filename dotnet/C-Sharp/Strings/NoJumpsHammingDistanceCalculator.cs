namespace Strings;

public class NoJumpsHammingDistanceCalculator : HammingDistanceCalculator
{
    // Pascal Style
    // That is, no jumps
    public override int? CalculateDistance(string a, string b)
    {
        int? distance;

        if (a.Length == b.Length && a.Length > 0)
        {
            distance = 0;
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    distance++;
                }
            }
        }
        else
        {
            distance = null;
        }
        
        return distance;
    }
}