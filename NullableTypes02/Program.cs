using System;

namespace NullableTypes02
{
    class Program
    {
        static void Main(string[] args)
        {
            TesterMethod(new string[] { "klsdfjl","kjdgskjgs","ksdhgs" });
            TesterMethod(null);
            Console.WriteLine("Hello World!");
        }

        static void TesterMethod(string[] arg)
        {
            //Перед доступом к данным массива мы должны проверить его на равенство null
            if(arg != null)
            {
                Console.WriteLine($"You sent me {arg?.Length}");
            }
            //Чтобы устранить обращение к свойству Length массива string в случае,
            //когда он равен null, здесь используется условный оператор. Если 
            //вызывающий код не создаст массив данных и вызовет метод
            //TesterMethod() примерно так, как показано ниже, то никаких ошибок во время
            //выполнения не возникнет
        }
    }
}
