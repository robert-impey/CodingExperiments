using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PairCount.Lib;

namespace PairCount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new Exception("I need something to work with!");
                }
                else
                {
                    int k;
                    if (int.TryParse(args[0], out k))
                    {
                        int[] a = new int[args.Length - 1];

                        for (int i = 1; i < args.Length; i++)
                        {
                            int temp;
                            if (int.TryParse(args[i], out temp))
                            {
                                a[i - 1] = temp;
                            }
                            else
                            {
                                throw new Exception("Unable to parse element for a!");
                            }
                        }

                        Console.WriteLine(string.Format("{0} pairs found.",
                            PairCounter.Count(k, a)));
                    }
                    else
                    {
                        throw new Exception("Unable to parse k!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
