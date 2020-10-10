using System;

namespace Event03
{
    class Program
    {
        public static event Action<string> Exploded;
        public static int speed = 0;

        static void Main(string[] args)
        {
            Exploded += Method1;
            Exploded = Method2;


            for(int i = 0; i < 10; i++)
            {
                if (speed % 3 == 0)
                {
                    Exploded("Boom!");
                }
                else
                    Exploded("Bang!");
                speed += 1;
            }
        }

        static void Method1(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Method2(string msg)
        {
            Console.WriteLine(msg + "_5");
        }


    }
}
