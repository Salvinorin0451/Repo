using System;

namespace Operation01
    //Троелсон 143
    //Условная операция
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void ExecuteIfElseUsingConditionalOperator()
        {
            string stringData = "MyTextualData";
            Console.WriteLine(stringData.Length > 0
                ? "2"
                : "1");

        }
    }

}
