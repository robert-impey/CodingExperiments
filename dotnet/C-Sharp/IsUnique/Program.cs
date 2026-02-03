namespace IsUnique;

public class Program
{
    static void Main(string[] args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine($"Is '{arg}' all unique?");
            Console.WriteLine($"IsUnique: '{IsUnique(arg)}");
            Console.WriteLine($"IsUniqueNoDataStructure: '{IsUniqueNoDataStructure(arg)}");
            Console.WriteLine($"IsUniqueNoJumps: '{IsUniqueNoJumps(arg)}");
            
            Console.WriteLine();
        }
    }

    private static bool IsUnique(string str)
    {
        var counts = new Dictionary<char, int>();

        for (var i = 0; i < str.Length; i++)
        {
            var c = str[i];
            if (counts.ContainsKey(c))
            {
                counts[c]++;
            }
            else
            {
                counts[c] = 1;
            }
        }

        return !counts.Any(kv => kv.Value > 1);
    }

    private static bool IsUniqueNoDataStructure(string str)
    {
        for (var i = 0; i < str.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (str[j] == str[i])
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static bool IsUniqueNoJumps(string str)
    {
        var foundDuplicate = false;

        for (var i = 0; i < str.Length && !foundDuplicate; i++)
        {
            for (var j = 0; j < i && !foundDuplicate; j++)
            {
                if (str[j] == str[i])
                {
                    foundDuplicate = true;
                }
            }
        }

        return !foundDuplicate;
    }
}
