using System;

namespace IsPermutation;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Please give me two strings!");
        }
        else
        {
            var first = args[0];
            var second = args[1];

            Console.WriteLine($"Is '{first}' a permutation of '{second}'? {IsPermutation(first, second)}");
        }
    }

    private static bool IsPermutation(string first, string second)
    {
        if (first.Length != second.Length)
        {
            return false;
        }

        var stringLength = first.Length;

        var firstCharArray = new char[stringLength];
        var secondCharArray = new char[stringLength];

        for (var i = 0; i < stringLength; i++)
        {
            firstCharArray[i] = first[i];
            secondCharArray[i] = second[i];
        }

        Array.Sort(firstCharArray);
        Array.Sort(secondCharArray);

        for (var i = 0; i < stringLength; i++)
        {
            if (firstCharArray[i] != secondCharArray[i])
            {
                return false;
            }
        }

        return true;
    }
}
