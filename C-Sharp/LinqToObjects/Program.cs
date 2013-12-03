using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up the objects...
            var a1 = new A
            {
                Name = "A1",
                Description = "In seed time learn, in harvest teach, in winter enjoy."
            };

            a1.Bs.Add(
                new B 
                { 
                    Name = "A1 B1",
                    Description = "Drive your cart and your plow over the bones of the dead."
                }
            );
            a1.Bs.Add(
                new B 
                { 
                    Name = "A1 B2",
                    Description = "The road of excess leads to the palace of wisdom."
                }
            );

            var a2 = new A
            {
                Name = "A2",
                Description = "Prudence is a rich, ugly old maid courted by Incapacity."
            };

            a2.Bs.Add(
                new B 
                { 
                    Name = "A2 B1",
                    Description = "He who desires but acts not, breeds pestilence."
                }
            );
            a2.Bs.Add(
                new B 
                { 
                    Name = "A2 B2",
                    Description = "The cut worm forgives the plow."
                }
            );

            var someAs = new List<A>();
            someAs.Add(a1);
            someAs.Add(a2);

            var someCs = new List<C>();
            someCs.Add(
                new C 
                { 
                    Name = "C1 A1", 
                    A = a1,
                    Description = "Dip him in the river who loves water."
                }
            );

            // Querying
            foreach (var a in from a in someAs
                              where Regex.IsMatch(a.Description, "harvest")
                              select a)
            {
                Console.WriteLine(a);
            }

            foreach (var b in from a in someAs
                              from b in a.Bs
                              where Regex.IsMatch(b.Description, "o(?:u|w)")
                              select b)
            {
                Console.WriteLine(b);
            }

            foreach (var a in from a in someAs
                              join c in someCs on a equals c.A
                              select a)
            {
                Console.WriteLine(a);
            }
        }
    }
}
