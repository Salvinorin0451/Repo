using System;

namespace DelegateFunc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func = new Func<int, int, int>(Add);

            Func<int, int, string> func1 = new Func<int, int, string>(SumToString);

            Console.WriteLine(func(4,5));
            Console.WriteLine(func1(44,44));
        }

        static int Add(int x, int y) => x + y;

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }


}
