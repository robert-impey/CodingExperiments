using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalindromeChecker.Lib;

/**
 * For searching a dictionary file for palindromes.
 * 
 * e.g. Civic Eve did a gig. Wow, madam! Pop solos deified a toot.
 */

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var wordFileName in args)
            {
                using (var wordFileReader = File.OpenText(wordFileName))
                {
                    while (true)
                    {
                        var line = wordFileReader.ReadLine();

                        if (line == null)
                            break;

                        var wordToCheck = line.Trim();

                        if (PalindromeChecker.Lib.PalindromeChecker.IsPalindrome(wordToCheck))
                            Console.WriteLine(wordToCheck);
                    }
                }
            }
        }
    }
}
