using System.Text;

namespace TextReversal
{
    public static class Reverser
    {
        public static string Reverse(string input)
        {
            var output = new StringBuilder();

            for (var i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }

            return output.ToString();
        }
    }
}
