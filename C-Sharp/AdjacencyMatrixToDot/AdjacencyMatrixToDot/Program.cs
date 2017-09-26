using System;
using System.Collections.Generic;
using System.IO;

namespace AdjacencyMatrixToDot
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                // Parse the file
                bool inLabels = true;
                var labels = new List<string>();
                var matrix = new List<List<int>>();
                foreach (var line in File.ReadAllLines(arg))
                {
                    if (inLabels)
                    {
                        if (string.IsNullOrEmpty(line))
                        {
                            inLabels = false;
                        }
                        else
                        {
                            labels.Add(line);
                        }
                    }
                    else
                    {
                        var rowRaw = line.Split(' ');
                        var row = new List<int>();
                        foreach (var rawValue in rowRaw)
                        {
                            int parsedValue;
                            if (int.TryParse(rawValue, out parsedValue))
                            {
                                row.Add(parsedValue);
                            }
                        }
                        matrix.Add(row);
                    }
                }

                // Print the dot file
                Console.WriteLine("graph {");

                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix[i].Count; j++)
                    {
                        if (matrix[i][j] == 1)
                        {
                            Console.WriteLine($"\t{labels[i]} -- {labels[j]}");
                        }
                    }
                }

                Console.WriteLine("}");
            }
        }
    }
}
