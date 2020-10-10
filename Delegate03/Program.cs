using System;

//Троелсон 384
//Пример простейшего делегата
namespace Delegate03
{
    public delegate int BinaryOp(int x, int y);

    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryOp b = new BinaryOp(SimpleMath.Add);

            Console.WriteLine($"{b(10,10)}");
        }
    }


}
