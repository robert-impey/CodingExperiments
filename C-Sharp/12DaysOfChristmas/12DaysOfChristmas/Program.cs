using System;

namespace _12DaysOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGifts = 0;

            for (int dayOfChristmas = 1; dayOfChristmas <= 12; dayOfChristmas++)
            {
                for (int gifts = 1; gifts <= dayOfChristmas; gifts++)
                {
                    totalGifts += gifts;
                }
            }

            Console.WriteLine("The total number of gifts: " + totalGifts);
        }
    }
}
