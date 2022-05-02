using static System.Linq.Enumerable;

const int max = 30;

Console.WriteLine("With a for loop:");

for (var i = 1; i <= max; i++)
{
    Console.Write(i + ": ");

    if (i % 3 == 0)
    {
        Console.Write("Fizz! ");
    }

    if (i % 5 == 0)
    {
        Console.Write("Buzz!");
    }

    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("With LINQ");

var numbers = Range(1, max).ToArray();
var fizz = (from n in numbers
    where n % 3 == 0
    select n).ToArray();
var buzz = (from n in numbers
    where n % 5 == 0
    select n).ToArray();

foreach (var n in numbers)
{
    Console.Write(n + ": ");

    if (fizz.Contains(n))
    {
        Console.Write("Fizz! ");
    }

    if (buzz.Contains(n))
    {
        Console.Write("Buzz!");
    }

    Console.WriteLine();
}
