using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectsOrientation
{
    class E : IC, IF, IG
    {
        void IC.MethodC()
        {
            Console.WriteLine("In E.MethodC");
        }

        void IF.MethodD()
        {
            Console.WriteLine("In E.MethodD, IF");
        }

        void IG.MethodD()
        {
            Console.WriteLine("In E.MethodD, IG");
        }
    }
}
