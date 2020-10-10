using System;

namespace DelegateGeneric01
{
    public delegate void MyGenericDelegate<T>(T arg);

    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDelegate<string> myGeneric = new MyGenericDelegate<string>(StringTarget);
            myGeneric("Some string");

            MyGenericDelegate<int> myGeneric1 = new MyGenericDelegate<int>(IntLine);
            myGeneric1(9);

            myGeneric = new MyGenericDelegate<string>(StrintLower);
            myGeneric += new MyGenericDelegate<string>(StringTarget);

            myGeneric("StRing");

            myGeneric -= StringTarget;

            myGeneric("StrinG");
        }

        static void StringTarget (string arg)
        {
            Console.WriteLine(arg.ToUpper());
        }

        static void IntLine(int arg)
        {
            Console.WriteLine(arg);
        }

        static void StrintLower (string arg)
        {
            Console.WriteLine(arg.ToLower());
        }
    }
}
