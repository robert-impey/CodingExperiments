using System.Runtime.CompilerServices;
using static System.Console;

namespace CallerInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrinterA();
            PrinterB();
        }

        private static void PrintCaller(
            [CallerMemberName] string memberName = "")
        {
            WriteLine("In PrintCaller");
            WriteLine($"Called by {memberName}");
        }

        private static void PrinterA()
        {
            PrintCaller();
        }

        private static void PrinterB()
        {
            PrintCaller();
        }
    }
}