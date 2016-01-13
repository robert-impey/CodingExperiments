using static System.Console;

namespace JumpingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //var containsBananas = ContainsBananasLoop(args);
            var containsBananas = ContainsBananasJumpingLoop(args);

            if (containsBananas)
            {
                WriteLine("Bananas found!");
            }
            else
            {
                WriteLine("Yes! We have no bananas!");
            }
        }

        private static bool ContainsBananasLoop(string[] args)
        {
            var containsBananas = false;

            foreach (var arg in args)
            {
                // Resharper will suggest inverting this if statement
                // to the code in the next method.
                if (arg == "bananas")
                {
                    containsBananas = true;
                    break;
                }
            }
            
            return containsBananas;
        }

        private static bool ContainsBananasJumpingLoop(string[] args)
        {
            var containsBananas = false;
            foreach (var arg in args)
            {
                if (arg != "bananas")
                {
                    continue;
                }

                containsBananas = true;
                break;
            }

            return containsBananas;
        }
    }
}
