using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Windows.Markup;

namespace DelegatePractics01
{
    public delegate void Handler(string a);
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler(Method);
            Handler handler1 = new Handler((x) => Console.WriteLine($"01 {x}"));


            handler1("444");
        }

        static void Method(string a) => Console.WriteLine($"{a}");

    }
}
