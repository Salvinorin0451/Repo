using System;

namespace DelegateAction01
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            

            actionTarget("Action Message", ConsoleColor.Yellow, 5);
        }

        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for(int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = previous;
        }
    }

    class Generics<T>
    {
        public void ShowMe()
    }
}
