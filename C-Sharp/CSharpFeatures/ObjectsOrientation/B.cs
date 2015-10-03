using System;

namespace ObjectsOrientation
{
    class B : A
    {
        internal new void MethodA()
        {
            Console.WriteLine("In B.MethodA");
        }

        internal override void MethodB()
        {
            Console.WriteLine("In B.MethodB");
        }
    }
}
