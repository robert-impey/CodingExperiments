using System.Text;

namespace ReverseString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Give me a string to work with!");
                return;
            }

            foreach (var stringToReverse in args)
            {
                var reversedString = ReverseString(stringToReverse);

                Console.WriteLine(reversedString);
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