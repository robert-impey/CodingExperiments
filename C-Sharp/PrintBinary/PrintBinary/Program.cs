using static System.Console;

namespace PrintBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                if (int.TryParse(arg, out int n))
                {
                    PrintBinary(n);
                }
            }
        }

        private static void PrintBinary(int n)
        {
            var numBits = 32;
            var checkBit = 0x80000000;

            for (int i = 0; i < numBits; i++)
            {
                if ((checkBit & n) == 0)
                {
                    Write(0);
                }
                else
                {
                    Write(1);
                }

                n = n << 1;
            }

            WriteLine();
        }
    }
}
