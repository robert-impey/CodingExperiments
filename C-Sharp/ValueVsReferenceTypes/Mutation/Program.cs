using ValueVsReferenceTypes;
using static System.Console;

namespace Mutation
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Initialize the class and struct");
            var myClass = new MyClass { MyInt = 5 };
            WriteLine($"myClass.MyInt: {myClass.MyInt}");

            var myStruct = new MyStruct { MyInt = 7 };
            WriteLine($"myStruct.MyInt: {myStruct.MyInt}");

            WriteLine("Assign myClass a 2nd time");
            var my2ndClass = myClass;

            WriteLine("Change the value in myClass");
            myClass.MyInt = 10;
            WriteLine($"myClass.MyInt: {myClass.MyInt}");
            WriteLine($"my2ndClass.MyInt: {my2ndClass.MyInt}");

            WriteLine("Assign myStruct a 2nd time");
            var my2ndStruct = myStruct;

            WriteLine("Change the value in myStruct");
            myStruct.MyInt = 14;
            WriteLine($"myStruct.MyInt: {myStruct.MyInt}");
            WriteLine($"my2ndStruct.MyInt: {my2ndStruct.MyInt}");

            MyMutatingProcedure(myClass);
            WriteLine($"myClass.MyInt: {myClass.MyInt}");
            WriteLine($"my2ndClass.MyInt: {my2ndClass.MyInt}");

            MyMutatingProcedure(myStruct);
            WriteLine($"myStruct.MyInt: {myStruct.MyInt}");
            WriteLine($"my2ndStruct.MyInt: {my2ndStruct.MyInt}");

            MyMutatingRefProcedure(ref myStruct);
            WriteLine($"myStruct.MyInt: {myStruct.MyInt}");
            WriteLine($"my2ndStruct.MyInt: {my2ndStruct.MyInt}");
        }

        static void MyMutatingProcedure(MyClass myClass)
        {
            WriteLine("Inside MyMutatingProcedure(MyClass myClass)");
            myClass.MyInt = 15;
            WriteLine($"myClass.MyInt: {myClass.MyInt}");
        }

        static void MyMutatingProcedure(MyStruct myStruct)
        {
            WriteLine("Inside MyMutatingProcedure(MyStruct myStruct)");
            myStruct.MyInt = 21;
            WriteLine($"myStruct.MyInt: {myStruct.MyInt}");
        }

        static void MyMutatingRefProcedure(ref MyStruct myStruct)
        {
            WriteLine("Inside MyMutatingProcedure(MyStruct myStruct)");
            myStruct.MyInt = 28;
            WriteLine($"myStruct.MyInt: {myStruct.MyInt}");
        }
    }
}