using System;
using NSubstitute;

namespace NSubstituteDoWhen
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var appleCounter = 0;

            var fooPutter = Substitute.For<IFooPutter>();

            fooPutter.When(x => x.Put(Arg.Any<string>())).Do(x => counter++);
            fooPutter.When(x => x.Put("apples")).Do(x => appleCounter++);

            fooPutter.Put("apples");
            fooPutter.Put("bananas");

            Console.WriteLine($"Counter: {counter}");
            Console.WriteLine($"Apple Counter: {appleCounter}");
        }
    }
}
