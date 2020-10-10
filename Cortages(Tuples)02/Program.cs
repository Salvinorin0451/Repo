using System;

namespace Cortages_Tuples_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new { Prop1 = "first", Prob2 = "second" };
            var bar = (foo.Prop1, foo.Prob2);

            Console.WriteLine(bar.Prop1, bar.Prob2);
            Console.WriteLine(foo.Prop1, foo.Prob2);

            Console.WriteLine(foo.GetType());

            (string, string) ba = (foo.Prop1, foo.Prob2);

            Console.WriteLine(ba.Item1, ba.Item2);

            Console.WriteLine(Method());
            Console.WriteLine(Method().Item1);

            Console.WriteLine("Hello World!");

            //Использование отбрасывания с кортежами

            var (first, _, last) = SplitNames();
            Console.WriteLine($"{first}:{last}");

        }

        static (int, string, int) Method()
        {
            return (5, "jhk", 44);
        }


        static (string, string, string) SplitNames()
        {
            return ("A", "B", "C");
        }
    }
}
                          