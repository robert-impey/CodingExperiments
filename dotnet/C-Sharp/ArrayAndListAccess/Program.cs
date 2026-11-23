using CommandLine;
using System.Diagnostics;
using static System.Console;

namespace ArrayAndListAccess;

class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                WriteLine($"Experimenting with a sequence of {options.SizeOfSequence} numbers.");

                TestEmpty(options.SizeOfSequence, options.NumberOfAccesses);
                TestArray(options.SizeOfSequence, options.NumberOfAccesses);
                TestList(options.SizeOfSequence, options.NumberOfAccesses);
                TestListElementAt(options.SizeOfSequence, options.NumberOfAccesses);
                TestLinkedList(options.SizeOfSequence, options.NumberOfAccesses);
            });
    }

    private sealed class Options
    {
        [Option('S', "sizeOfSequence", Required = true)]
        public int SizeOfSequence { get; set; }

        [Option('A', "numberOfAccesses", Required = true)]
        public int NumberOfAccesses { get; set; }
    }

    private static void TestEmpty(int sizeOfSequence, int numberOfAccesses)
    {
        WriteLine("Testing doing nothing");

        var stopwatch = new Stopwatch();

        stopwatch.Start();

        var rand = new Random();

        for (var i = 0; i < numberOfAccesses; i++)
        {
            var index = rand.Next(sizeOfSequence);
        }

        stopwatch.Stop();

        WriteLine($"Nothing accessed in {stopwatch.ElapsedMilliseconds} ms.");
    }

    private static void TestArray(int sizeOfSequence, int numberOfAccesses)
    {
        WriteLine("Testing the array");

        var ary = new int[sizeOfSequence];

        for (var i = 0; i < sizeOfSequence; i++)
        {
            ary[i] = i;
        }

        var stopwatch = new Stopwatch();

        stopwatch.Start();

        var rand = new Random();

        for (var i = 0; i < numberOfAccesses; i++)
        {
            var index = rand.Next(sizeOfSequence);

            var ele = ary[index];
        }

        stopwatch.Stop();

        WriteLine($"Accessed in {stopwatch.ElapsedMilliseconds} ms.");
    }

    private static void TestList(int sizeOfSequence, int numberOfAccesses)
    {
        WriteLine("Testing the list");

        var list = new List<int>();

        for (var i = 0; i < sizeOfSequence; i++)
        {
            list.Add(i);
        }

        var stopwatch = new Stopwatch();

        stopwatch.Start();

        var rand = new Random();

        for (var i = 0; i < numberOfAccesses; i++)
        {
            var index = rand.Next(sizeOfSequence);

            var ele = list[index];
        }

        stopwatch.Stop();

        WriteLine($"Accessed in {stopwatch.ElapsedMilliseconds} ms.");
    }

    private static void TestListElementAt(int sizeOfSequence, int numberOfAccesses)
    {
        WriteLine("Testing the list with element at");

        var list = new List<int>();

        for (var i = 0; i < sizeOfSequence; i++)
        {
            list.Add(i);
        }

        var stopwatch = new Stopwatch();

        stopwatch.Start();

        var rand = new Random();

        for (var i = 0; i < numberOfAccesses; i++)
        {
            var index = rand.Next(sizeOfSequence);

            var ele = list.ElementAt(index);
        }

        stopwatch.Stop();

        WriteLine($"Accessed in {stopwatch.ElapsedMilliseconds} ms.");
    }

    private static void TestLinkedList(int sizeOfSequence, int numberOfAccesses)
    {
        WriteLine("Testing the linked list");

        var list = new LinkedList<int>();

        for (var i = 0; i < sizeOfSequence; i++)
        {
            list.AddLast(i);
        }

        var stopwatch = new Stopwatch();

        stopwatch.Start();

        var rand = new Random();

        for (var i = 0; i < numberOfAccesses; i++)
        {
            var index = rand.Next(sizeOfSequence);

            var ele = list.ElementAt(index);
        }

        stopwatch.Stop();

        WriteLine($"Accessed in {stopwatch.ElapsedMilliseconds} ms.");
    }
}
