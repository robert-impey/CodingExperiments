using System;
using System.Collections.Generic;
using System.Linq;

namespace IsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine($"Is '{arg}' all unique? {IsUnique(arg)}");
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
    }
}
