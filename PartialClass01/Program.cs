using System;

namespace PartialClass01
{
    //Троелсон 240
    //Понятие частичных классов
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    partial class Employee
    {
         public string A { get { return a; } set { a = value; } }

    }
}
