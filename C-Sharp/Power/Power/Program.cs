using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // See page 15 of
            // Algorithms + Data Structures = Programs
            // by Nicklaus Wirth

            const int n = 10;
            int i, k, r;
            var d = new int[n];

            for (k = 0; k < n; k++)
            {
                Console.Write('.');
                r = 0;
                for (i = 0; i < k; i++)
                {
                    r = 10 * r + d[i];
                    d[i] = r / 2;
                    r = r - 2 * d[i];
                    Console.Write(d[i]);
                }
                d[k] = 5;
                Console.WriteLine(5);
            }
        }
    }
}
