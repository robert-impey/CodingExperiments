namespace LeetCode;

public class FindHammingDistance
{
    public int HammingDistance(int x, int y)
    {
        var distance = 0;

        var numBits = 32;
        var checkBit = 0x80000000;

        for (int i = 0; i < numBits; i++)
        {
            if ((checkBit & x) != (checkBit & y))
            {
                distance++;
            }

            x = x << 1;
            y = y << 1;
        }

        return distance;
    }
}
