using System;
using System.Diagnostics;
using static System.Console;

namespace ParamObjectPerf
{
    class ParamObj
    {
        internal int A { get; set; }
        internal int B { get; set; }
    }

    class Program
    {
        static int Foo(int a, int b)
        {
            return a + b;
        }

        static int Foo(ParamObj paramObj)
        {
            return paramObj.A + paramObj.B;
        }

        static void Main(string[] args)
        {
            int iterations;
            if (args.Length > 0 && int.TryParse(args[0], out iterations))
            {
                WriteLine($"{iterations} iterations");

                var stopWatch = new Stopwatch();
                var rand = new Random();
                var max = 10;

                stopWatch.Start();

                for (var i = 0; i < iterations; i++)
                {
                    Foo(rand.Next(max), rand.Next(max));
                }

                stopWatch.Stop();

                WriteLine("Foo with ints: " + stopWatch.ElapsedMilliseconds);

                stopWatch.Restart();

                for (var i = 0; i < iterations; i++)
                {
                    Foo(new ParamObj { A = rand.Next(max), B = rand.Next(max) });
                }

                stopWatch.Stop();

                WriteLine("Foo with ParamObj: " + stopWatch.ElapsedMilliseconds);
            }
        }
    }
}
