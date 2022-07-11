using System;
using System.Diagnostics;
using System.Threading.Tasks;
using static System.Console;

namespace MultipleAsync
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            decimal total = 0m;
            
            stopwatch.Reset();
            stopwatch.Start();

            total += await GetX();
            total += await GetY();
            
            stopwatch.Stop();

            WriteLine($"Total of {total} found sequentially: {stopwatch.ElapsedMilliseconds} ms");

            // See page 478 of "C# in Depth" 3rd Ed. by Jon Skeet
            total = 0m;
            
            stopwatch.Reset();
            stopwatch.Start();

            Task<decimal> xTask = GetX();
            Task<decimal> yTask = GetY();
            
            total += await xTask;
            total += await yTask;
            
            stopwatch.Stop();
            WriteLine($"Total of {total} found in parallel: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static async Task<decimal> GetX()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(500));
            return 1m;
        }

        private static async Task<decimal> GetY()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(300));
            return 2m;
        }
    }
}