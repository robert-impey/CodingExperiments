/**
 * For searching a dictionary file for palindromes.
 * 
 * e.g. Civic Eve did a gig. Wow, madam! Pop solos deified a toot.
 */

namespace PalindromeChecker;

class Program
{
    static void Main(string[] args)
    {
        foreach (var wordFileName in args)
        {
            using var wordFileReader = File.OpenText(wordFileName);
            while (true)
            {
                var line = wordFileReader.ReadLine();

                if (line == null)
                    break;

                var wordToCheck = line.Trim();

                var palindromeChecker = new Lib.StackPalindromeChecker();
                if (palindromeChecker.IsPalindrome(wordToCheck))
                    Console.WriteLine(wordToCheck);
            }
        }
    }
}
