using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectsOrientation
{
    class A
    {
        internal void MethodA()
        {
            Console.WriteLine("In A.MethodA");
        }

        internal virtual void MethodB()
        {
            Console.WriteLine("In A.MethodB");
        }
    }
}
