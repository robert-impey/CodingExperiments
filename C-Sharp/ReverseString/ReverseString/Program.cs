using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var stringToReverse = args[0];

                var reversedString = ReverseString(stringToReverse);

                Console.WriteLine(reversedString);
            }
            else
            {
                Console.WriteLine("Give me a string to work with!");
            }
        }

        private static string ReverseString(string stringToReverse)
        {
            var tempStack = new Stack<char>();
            
            foreach (var c in stringToReverse)
            {
                tempStack.Push(c);
            }

            var reversedString = new StringBuilder();

            foreach (var c in tempStack)
            {
                reversedString.Append(c);
            }

            return reversedString.ToString();
        }
    }
}
