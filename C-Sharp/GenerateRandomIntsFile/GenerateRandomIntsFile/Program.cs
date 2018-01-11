using CommandLine;
using System;
using System.IO;
using static System.Console;

namespace GenerateRandomIntsFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithNotParsed(_ =>
                {
                    WriteLine("Unable to parse the args!");
                })
                .WithParsed(opt =>
                {
                    var fileName = Path.Combine(opt.Directory, $"rand_{opt.Min}_{opt.Max}_{opt.Number}.txt");

                    using (var outputFile = new StreamWriter(fileName))
                    {
                        var prng = new Random();
                        for (var i = 0; i < opt.Number; i++)
                        {
                            outputFile.WriteLine(prng.Next(opt.Min, opt.Max));
                        }
                    }
                });
        }
    }

    internal class Options
    {
        [Option('m', "max", Default = int.MaxValue, HelpText = "The max random number.")]
        public int Max { get; set; }

        [Option('n', "min", Default = int.MinValue, HelpText = "The min random number.")]
        public int Min { get; set; }

        [Option('r', "number", Default = 100000, HelpText = "The number of numbers to generate.")]
        public int Number { get; set; }

        [Option('d', "directory", Default = ".", HelpText = "The directory in which to save the file.")]
        public string Directory { get; set; }
    }
}
