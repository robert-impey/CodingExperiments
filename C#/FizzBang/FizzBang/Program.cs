using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBang
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = 30;

            Console.WriteLine("With a for loop:");

            for (var i = 1; i <= max; i++)
            {
                Console.Write(i + ": ");

                if (i % 3 == 0)
                {
                    Console.Write("Fizz! ");
                }

                if (i % 5 == 0)
                {
                    Console.Write("Bang!");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("With LINQ");

            var numbers = Enumerable.Range(1, max);
            var fizz = from n in numbers
                       where n % 3 == 0
                       select n;
            var bang = from n in numbers
                       where n % 5 == 0
                       select n;

            foreach (var n in numbers)
            {
                Console.Write(n + ": ");

                if (fizz.Contains(n))
                {
                    Console.Write("Fizz! ");
                }

                if (bang.Contains(n))
                {
                    Console.Write("Bang!");
                }

                Console.WriteLine();
            }
        }
    }
}
