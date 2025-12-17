using System.Diagnostics;
using static System.Console;

namespace EnumerableCounting;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            var smallCountUpSequence = new CountUpSequence(10);

            WriteLine("Count up sequence elements:");
            foreach (var i in smallCountUpSequence)
            {
                WriteLine(i);
            }
        }
        else
        {
            foreach (var arg in args)
            {
                int max;
                if (int.TryParse(arg, out max))
                {
                    CountCountUpSequence(max);
                    CountLinkedList(max);
                    CountList(max);
                }
            }
        }
    }

    private static void CountList(int max)
    {
        WriteLine("Lists");

        var stopWatch = new Stopwatch();

        stopWatch.Start();
        var l = new List<int>();
        for (var i = 0; i < max; i++)
        {
            l.Add(i);
        }
        stopWatch.Stop();
        WriteLine("Time to initialise: " + stopWatch.ElapsedMilliseconds);

        stopWatch.Restart();
        WriteLine(l.Count);
        stopWatch.Stop();
        WriteLine("Time to count with prop: " + stopWatch.ElapsedMilliseconds);

        stopWatch.Restart();
        WriteLine(l.Count());
        stopWatch.Stop();
        WriteLine("Time to count with extension method: " + stopWatch.ElapsedMilliseconds);

        WriteLine();
    }

    private static void CountLinkedList(int max)
    {
        WriteLine("Linked lists");

        var stopWatch = new Stopwatch();

        stopWatch.Start();
        var ll = new LinkedList<int>();
        for (var i = 0; i < max; i++)
        {
            ll.AddLast(i);
        }
        stopWatch.Stop();
        WriteLine("Time to initialise: " + stopWatch.ElapsedMilliseconds);

        stopWatch.Restart();
        WriteLine(ll.Count);
        stopWatch.Stop();
        WriteLine("Time to count with prop: " + stopWatch.ElapsedMilliseconds);

        stopWatch.Restart();
        WriteLine(ll.Count());
        stopWatch.Stop();
        WriteLine("Time to count with extension method: " + stopWatch.ElapsedMilliseconds);

        WriteLine();
    }

    private static void CountCountUpSequence(int max)
    {
        WriteLine("Count up sequence");

        var stopWatch = new Stopwatch();

        stopWatch.Start();
        var cus = new CountUpSequence(max);
        stopWatch.Stop();
        WriteLine("Time to initialise: " + stopWatch.ElapsedMilliseconds);

        stopWatch.Restart();
        WriteLine(cus.Count());
        stopWatch.Stop();
        WriteLine("Time to count with extension method: " + stopWatch.ElapsedMilliseconds);

        stopWatch.Restart();
        var cusAsList = cus.ToList();
        stopWatch.Stop();
        WriteLine("Time to get list: " + stopWatch.ElapsedMilliseconds);

        stopWatch.Restart();
        WriteLine(cusAsList.Count);
        stopWatch.Stop();
        WriteLine("Time to count with prop from list: " + stopWatch.ElapsedMilliseconds);

        WriteLine();
    }
}
