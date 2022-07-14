using System.Diagnostics;
using static System.Console;

namespace ImperativeMapping
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int size = 10 * 1000 * 1000;

            var ys = new int[size];

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            for (var i = 0; i < size; i++)
            {
                ys[i] = i + i;
            }
            stopWatch.Stop();
            WriteLine($"Time to run one loop with many iterations: {stopWatch.ElapsedMilliseconds}");

            var zs = new int[10];

            stopWatch.Restart();
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < zs.Length; j++)
                {
                    zs[j] = j + j;
                }
            }
            stopWatch.Stop();
            WriteLine($"Time to run many loops with few iterations: {stopWatch.ElapsedMilliseconds}");

            stopWatch.Restart();
            for (var i = 0; i < size; i++)
            {
                ys[i] = F(i);
            }
            stopWatch.Stop();
            WriteLine($"Time to run one loop with a function with many iterations: {stopWatch.ElapsedMilliseconds}");

            stopWatch.Restart();
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < zs.Length; j++)
                {
                    zs[j] = F(j);
                }
            }
            stopWatch.Stop();
            WriteLine($"Time to run with a function many loops with few iterations: {stopWatch.ElapsedMilliseconds}");
        }

        private static int F(int x)
        {
            return x + x;
        }
    }
}
