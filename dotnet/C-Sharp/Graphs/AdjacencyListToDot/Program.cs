using System;
using System.IO;

namespace AdjacencyListToDot
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                Console.WriteLine("graph {");

                var fileName = args[0];

                foreach (var line in File.ReadAllLines(fileName))
                {
                    var vertices = line.Split(',');

                    if (vertices.Length < 2)
                    {
                        throw new Exception($"{line} does not have at least 2 vertices!");
                    }

                    for (var i = 1; i < vertices.Length; i++)
                    {
                        Console.WriteLine($"\t{vertices[0]} -- {vertices[i]}");
                    }
                }

                Console.WriteLine("}");
            }
            else
            {
                Console.WriteLine("Please give me just one file!");
            }
        }
    }
}
