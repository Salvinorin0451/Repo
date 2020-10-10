using System;

namespace Event02
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Exploded += Expa;
            car.ToBlow += Blow;

            car.Accelerate(10);
        }

        static void Expa(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Blow(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Car
    {
        public int CurrSpeed = 0;
        public int MaxSpeed = 100;
        public bool isDead = false;

        public delegate void Handler(string msg);

        public event Handler Exploded;
        public event Handler ToBlow;

        public void Accelerate(int arg)
        {
            for (int i = 0; i <= 11; i++)
            {
                if (isDead)
                {
                    Exploded("Car is Exploded");
                }
                else
                {
                    if (CurrSpeed >= 100)
                        isDead = true;
                    else
                    if (CurrSpeed >= 90 && CurrSpeed < 100)
                    {
                        ToBlow("Be Careeful");
                        Console.WriteLine(CurrSpeed);
                    }
                    else
                    {
                        Console.WriteLine(CurrSpeed);
                    }
                    
                }
                CurrSpeed += arg;
            }
        }
    }
}
