using System;
using System.Net.Http.Headers;

namespace Event05
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Exploded += Show;
            car.AboutToBlow += Show;
            for(int i = 0; i<10; i++)
            {
                car.Accelerate(10);
            }
        }

        static void Show(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Car
    {
        public delegate void CarEngineHandler(string msg);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public bool carIsDead;
        public int CurrentSpeed;
        public int MaxSpeed = 100;

        public void Accelerate(int delta)
        {
            if(carIsDead)
            {
                if (Exploded != null)
                    Exploded("this car is dead");
            }
            else
            {
                CurrentSpeed += delta;
                if(10 == MaxSpeed - CurrentSpeed && AboutToBlow != null)
                {
                    AboutToBlow("Careful");
                }

                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSped = {0}", CurrentSpeed);
            }
        }
    }
}
