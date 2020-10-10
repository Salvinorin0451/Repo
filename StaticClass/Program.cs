using System;
//Троелсон 214
//Определение статических классов
namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();
            Console.WriteLine("Hello World!");
        }
    }
    //Статические классы могут содержать только статические члены
    //Класс определен как статический - это означает, что нельзя создавать его экземпляры с помощью ключевого слова new
    static class TimeUtilClass
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
    }


}
