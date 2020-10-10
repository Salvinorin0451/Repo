using System;

//Троелсон 144
//Оператор Switch
namespace Switch01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void SwitchExamle()
        {
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    Console.WriteLine("is a fine");
                break;
                case 2:
                    Console.WriteLine("and more!");
                break;
                default:
                    Console.WriteLine("Well...");
                break;

            }
            //Язык требует чтобы каждый блок case (включая default), который содержит
            //исполняемые операторы, завершался оператором return, break или goto
            //во избежание сквозного прохода по блокам
        }

        static void StringChoice()
        {
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("is fine");
                    break;
                case "VB":
                    Console.WriteLine("More");
                    break;
                default:
                    Console.WriteLine("Well...");
                    break;
            }

            static void GotoChoice()
            {
                int langCoice = Int32.Parse(Console.ReadLine());
                switch (langCoice)
                {
                    case 1:
                        //to do that
                        goto case 2;
                    case 2:
                        //to do that
                        break;
                    case 3:
                        goto default;
                    default:
                        //default action
                        break;
                }
            }
        }
    }
}
