using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace FindDictionaryLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var dictionaryFile = args[0];

                var dictionary = new Dictionary<string, int>();

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var lineNumberFromFile = 0;
                foreach (var line in File.ReadAllLines(dictionaryFile))
                {
                    dictionary[line] = ++lineNumberFromFile;
                }
                stopwatch.Stop();
                WriteLine($"Loading {lineNumberFromFile} lines into the dictionary took {stopwatch.ElapsedMilliseconds} ms.");

                while (true)
                {
                    WriteLine("Look up which word?");
                    var lookUp = ReadLine();

                    int lineNumberFromDictionary;
                    stopwatch.Restart();
                    var found = dictionary.TryGetValue(lookUp, out lineNumberFromDictionary);
                    stopwatch.Stop();
                    WriteLine($"TryGetValue took {stopwatch.ElapsedMilliseconds} ms.");

                    if (found)
                    {
                        WriteLine($"{lookUp} is on line number {lineNumberFromDictionary}");
                    }
                    else
                    {
                        WriteLine($"{lookUp} is not in this dictionary.");
                    }
                }
            }
            else
            {
                WriteLine("Please give me a dictionary!");
            }
        }
    }
}
