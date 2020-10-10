using System;

namespace StaticUsing01
{
    //Испортирование статических членов с применением
    //ключевого слова using
    using static System.Console;
    using static System.DateTime;
    //Теперь можно обращаться напрямую к статическим членам этих классов
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static class TimeUtilClass
        {
            public static void PrintTime() => WriteLine(Now.ToShortDateString());
            public static void PrintDate() => WriteLine(Today.ToShortDateString());
        }
    }
}
