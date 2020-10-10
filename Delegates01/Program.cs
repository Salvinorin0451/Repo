using System;
using System.Security.Cryptography.X509Certificates;

//Троелсон 380
//Определение типа делегата в C#
namespace Delegates01
{
    class Program
    {
        //Объявление типа делегата
        public delegate int BinaryOp(int x, int y);

        //Еще один
        public delegate string Delegate2(bool a, bool b, bool c);

        //Еще один
        public delegate void Delegate3();

        static void Main(string[] args)
        {
            NewClass newClass = new NewClass();
            //создание экземпляра делегата
            //передача в контруктор метода
            BinaryOp op = new BinaryOp(Method);

            //Делегат void()
            Delegate3 delegate3;
            delegate3 = new Delegate3(newClass.Meth);

            NewClass2 newClass2 = new NewClass2(newClass.Meth2);
            newClass2.Show();

            newClass.Name = "Paul";
            newClass2.Show();

            newClass2.Name = "Robert";
            newClass2.Show();
            
        }

        static int Method(int x, int y)
        {
            return x + y;
        }

        class NewClass
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public void Meth()
            {
                Console.WriteLine("Piy");
            }

            public void Meth2()
            {
                Console.WriteLine("Piy2");
                Console.WriteLine($"{Name} {LastName}");
            }

            public void Show()
            {
                Console.WriteLine();
            }
        }

        class NewClass2
        {
            public string Name { get; set; }
            public delegate void dele();
            dele Dele;

            public NewClass2(dele dele)
            {
                Dele = new dele(dele);
            }

            public void Show()
            {
                Console.WriteLine($"{Name}");
                Dele();
            }
        }
    }
}
