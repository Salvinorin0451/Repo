using System;
//Троелсон 269
//Правила приведения ддля базовых и производных классов
namespace Casting01
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 1; i<=200; i++)
            {
                if (i % 2 == 0)
                    count += 1;
            }
            Console.WriteLine(count);
        }
    }

    class Employee
    {
        public string Name { get; set; }

    }


}
