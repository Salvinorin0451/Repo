using System;


//Троелсон страница 132


namespace Checked01
{
    class Program
    {
        static void Main(string[] args)
        {
            Processbytes();
        }

        static int Add(byte a, byte b)
        {
            return a + b;
        }

        static void Processbytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                byte sum = checked((byte)Add(b1, b2));   //происходит сужение диапозона допустимых значений
                Console.WriteLine($"sum = {sum}");    //ожидается на выходе 350, но на деле выходит 94 (350-256)
                //Ключевой слово checked указывает на необходимость перехватить возможное исключение
            }
            catch (OverflowException ex)      //Поскольку значение sum выходит за пределы допустимого
            //диапазона для типа byte, генерируется исключение времени выполнения.
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Processbytes2()
        {
            byte b1 = 100;
            byte b2 = 200;
            try
            {
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine($"sum={sum}");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
