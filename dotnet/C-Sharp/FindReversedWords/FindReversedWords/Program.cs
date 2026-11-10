using FindReversedWords.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FindReversedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please give me a file!");
            }
            else
            {
                var reversedWordFinder = new NaiveReversedWordFinder(
                    new StackReversedStringChecker());

                foreach (var fileName in args)
                {
                    Console.WriteLine(string.Format("Reading {0} ...", fileName));
                    var words = GetWordsFromFile(fileName);
                    var pairs = reversedWordFinder.FindReversedWords(words.AsQueryable());

                    foreach (var reversedWordPair in pairs)
                    {
                        Console.WriteLine(reversedWordPair);    
                    }
                }
            }
        }

        private static IEnumerable<string> GetWordsFromFile(string fileName)
        {
            using (var reader = File.OpenText(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
