using CommandLine;
using Graphs;
using static System.Console;

namespace GenerateAdjacencyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
               .WithNotParsed(_ =>
               {
                   WriteLine("Unable to parse the args!");
               })
               .WithParsed(opt =>
               {
                   var graph = GraphGenerator.Generate(opt.Size, opt.Threshold);

                   if (opt.Bidirectional)
                   {
                       DotPrinter.PrintBidirectional(graph);
                   }
                   else
                   {
                       DotPrinter.Print(graph);
                   }
               });
        }
    }

    internal class Options
    {
        [Option('s', "size", Default = 5, HelpText = "The size of the graph")]
        public int Size { get; set; }

        [Option('t', "threshold", Default = 0.3, HelpText = "The threshold for an edge")]
        public double Threshold { get; set; }

        [Option('b', "bidi", Default = true, HelpText = "Edges are considered bidirectional")]
        public bool Bidirectional { get; set; }
    }
}
