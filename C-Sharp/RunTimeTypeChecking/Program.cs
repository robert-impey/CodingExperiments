using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RunTimeTypeChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            var foods = new List<Food>();

            foods.Add(new Food("salty"));
            foods.Add(new ChickenSandwich("tangy"));

            foreach (var food in foods)
            {
                WriteLine(food.DescribeFlavour());

                WriteLine("as test");
                var foodAsChickenSandwich = food as ChickenSandwich;
                if (foodAsChickenSandwich == null)
                {
                    WriteLine("Not chicken sandwich");
                }
                else
                {
                    WriteLine("Is chicken sandwich");
                }

                WriteLine("is test");
                if (food is ChickenSandwich)
                {
                    WriteLine("Is chicken sandwich");
                }
                else
                {
                    WriteLine("Not chicken sandwich");
                }

                WriteLine("Type test");
                if (food.GetType() == typeof(ChickenSandwich))
                {
                    WriteLine("Is chicken sandwich");
                }
                else
                {
                    WriteLine("Not chicken sandwich");
                }

                WriteLine();
            }

            var firstFood = foods.First();
            const int testCount = 100000000;
            var stopWatch = new Stopwatch();
            int foodCount, chickenSandwichCount;

            WriteLine("Timing as");
            foodCount = chickenSandwichCount = 0;
            stopWatch.Start();
            for (var i = 0; i < testCount; i++)
            {
                var foodAsChickenSandwich = firstFood as ChickenSandwich;

                if (foodAsChickenSandwich == null)
                {
                    foodCount++;
                }
                else
                {
                    chickenSandwichCount++;
                }
            }
            stopWatch.Stop();
            WriteLine(stopWatch.ElapsedMilliseconds);
            WriteLine(string.Format("Food count: {0}\tChicken Sandwich count: {1}", foodCount, chickenSandwichCount));

            WriteLine("Timing is");
            foodCount = chickenSandwichCount = 0;
            stopWatch.Restart();
            for (var i = 0; i < testCount; i++)
            {
                if (firstFood is ChickenSandwich)
                {
                    chickenSandwichCount++;
                }
                else
                {
                    foodCount++;
                }
            }
            stopWatch.Stop();
            WriteLine(stopWatch.ElapsedMilliseconds);
            WriteLine(string.Format("Food count: {0}\tChicken Sandwich count: {1}", foodCount, chickenSandwichCount));

            WriteLine("Timing typeof");
            foodCount = chickenSandwichCount = 0;
            stopWatch.Start();
            for (var i = 0; i < testCount; i++)
            {
                if (firstFood.GetType() == typeof(ChickenSandwich))
                {
                    chickenSandwichCount++;
                }
                else
                {
                    foodCount++;
                }
            }
            stopWatch.Stop();
            WriteLine(stopWatch.ElapsedMilliseconds);
            WriteLine(string.Format("Food count: {0}\tChicken Sandwich count: {1}", foodCount, chickenSandwichCount));

            var swictchableFoods = new List<SwitchableFood>();

            swictchableFoods.Add(new SwitchableFood(FoodType.Food, "salty"));
            swictchableFoods.Add(new SwitchableFood(FoodType.ChickenSandwich, "tangy"));

            foreach(var swictchableFood in swictchableFoods)
            {
                WriteLine(swictchableFood.DescribeFlavour());
            }

            var firstSwitchableFood = swictchableFoods.First();
            WriteLine("Timing switching");
            foodCount = chickenSandwichCount = 0;
            stopWatch.Start();
            for (var i = 0; i < testCount; i++)
            {
                if (firstSwitchableFood.FoodType == FoodType.ChickenSandwich)
                {
                    chickenSandwichCount++;
                }
                else
                {
                    foodCount++;
                }
            }
            stopWatch.Stop();
            WriteLine(stopWatch.ElapsedMilliseconds);
            WriteLine(string.Format("Food count: {0}\tChicken Sandwich count: {1}", foodCount, chickenSandwichCount));
        }
    }
}
