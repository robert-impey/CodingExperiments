using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectsOrientation
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var b = new B();

            a.MethodA();
            b.MethodA();

            A bAsAnA = b;
            bAsAnA.MethodA();
            Console.WriteLine();

            a.MethodB();
            b.MethodB();
            bAsAnA.MethodB();
            Console.WriteLine();

            var varArray = new[] { a, b, bAsAnA };
            foreach (var obj in varArray)
            {
                obj.MethodA();
                obj.MethodB();
            }
            Console.WriteLine();

            var dAsVar = new D();
            dAsVar.MethodC();

            D dAsD = new D();
            dAsD.MethodC();

            IC dAsIC = new D();
            dAsIC.MethodC();
            Console.WriteLine();

            var ds = new [] { dAsD, dAsVar, dAsIC };

            foreach (var d in ds)
            {
                d.MethodC();
            }
            Console.WriteLine();

            foreach (D d in ds)
            {
                d.MethodC();
            }
            Console.WriteLine();

            foreach (IC d in ds)
            {
                d.MethodC();
            }
            Console.WriteLine();

            E eAsE = new E();
            //eAsE.MethodC();
            //eAsE.MethodD();

            var eAsVar = new E();
            //eAsVar.MethodC();
            //eAsVar.MethodD();

            IC eAsIC = new E();
            eAsIC.MethodC();

            IF eAsIF = new E();
            eAsIF.MethodD();
            Console.WriteLine();

            var es = new [] { eAsE, eAsVar, (E)eAsIC, (E)eAsIF };

            foreach (var e in es)
            {
                //e.MethodC();
                //e.MethodD();
            }

            foreach (E e in es)
            {
                //e.MethodC();
                //e.MethodD();
            }

            foreach (IC e in es)
            {
                e.MethodC();
            }
            Console.WriteLine();

            foreach (IF e in es)
            {
                e.MethodD();
            }
            Console.WriteLine();

            foreach (IG e in es)
            {
                e.MethodD();
            }
            Console.WriteLine();
         }
    }
}
