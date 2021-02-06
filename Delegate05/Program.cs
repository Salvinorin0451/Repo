using System;

namespace Delegate05
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);

            c1.RegisterWithCarEngine(OnCarEngineEvent);
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

        }

        private static void OnCarEngineEvent(string msgForCaller)
        {
            Console.WriteLine(msgForCaller);
        }

        public static int OnOnON()
        {
            return 4;
        }
    }

    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }

        private bool carIsDead;

        public void Accelerate(int delta)
        {
            if(carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Car is dead");
            }
            else
            {
                CurrentSpeed += delta;

                if(10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine(CurrentSpeed);
            }
        }

        public Car()
        {

        }

        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
    }
}
