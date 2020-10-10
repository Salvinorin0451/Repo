using System;


//Троесон 146
//Использование сопоставления с образцом в операторах switch (нововведение)
namespace Switch02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void ExecutePatternMatchingSwitch()
        {
            
            string userChoice = Console.ReadLine();
            object choice;

            switch(userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

             switch(choice)
            {
                case int i when i == 0:
                    Console.WriteLine("int");
                    break;
                case int i when i == 2:
                    Console.WriteLine("int");
                    break;
                case int i:
                    Console.WriteLine("int");
                    break;
                case string s:
                    s += s;
                    Console.WriteLine("string");
                    break;
                case decimal d:
                    Console.WriteLine("decimal");
                    break;
                default:
                    Console.WriteLine("else");
                    break;
            }
            
            
        }
    }
}
