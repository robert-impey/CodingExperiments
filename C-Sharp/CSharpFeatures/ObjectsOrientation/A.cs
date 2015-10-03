using System;

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
