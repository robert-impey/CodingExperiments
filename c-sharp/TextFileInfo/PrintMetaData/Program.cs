using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintMetaData
{
    class Program
    {
        static void Main(string[] args)
        {
            if ((args.Length == 0) || ("-h".Equals(args[0])))
            {
                Usage();
            }
            else
            {

            }
        }

        static void Usage()
        {
            Console.WriteLine("Print the Meta-data of a file.");
        }
    }
}
