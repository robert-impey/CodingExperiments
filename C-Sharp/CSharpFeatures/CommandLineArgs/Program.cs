using System;

namespace CommandLineArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args) 
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine(args.Length);

            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("No args!");
                    break;
                case 1:
                    Console.WriteLine("Your single arg: " + args[0]);

                    if (args[0].Equals("-h") || "--help".Equals(args[0]))
                    {
                        Console.WriteLine("You are asking for help.");
                    }
                    break;
                default:
                    Console.WriteLine(args.Length + " args");
                    break;
            }
        }
    }
}
