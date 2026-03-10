using CommandLine;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace FindEquilibriumIndex
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            await Parser.Default.ParseArguments<Options>(args)
                .WithNotParsed(_ =>
                {
                    WriteLine("Unable to parse the args!");
                })
                .WithParsedAsync(async opt =>
                {
                    await PrintEquilibriumIndex(opt.FileName);
                });
        }

        private static async Task PrintEquilibriumIndex(string fileName)
        {
            var numbers = ReadFile(fileName);

            var a = await numbers.ToArrayAsync();

            var equilibriumIndex = FindEquilibriumIndex(a, a.Length);

            WriteLine(equilibriumIndex);
        }

        private static int FindEquilibriumIndex(int[] a, int n)
        {
            long sum = 0;

            for (var i = 0; i < n; i++)
            {
                sum += a[i];
            }

            long left = 0;
            long right = sum;

            for (var i = 0; i < n; i++)
            {
                right -= a[i];

                if (left == right)
                {
                    return i;
                }

                left += a[i];
            }

            return -1;
        }

        private static async IAsyncEnumerable<int> ReadFile(string fileName)
        {
            foreach (var line in await File.ReadAllLinesAsync(fileName))
            {
                if (int.TryParse(line, out int n))
                {
                    yield return n;
                }
            }
        }
    }

    internal class Options
    {
        [Option('f', "file", HelpText = "The file containing the integers")]
        public string FileName { get; set; }
    }
}
