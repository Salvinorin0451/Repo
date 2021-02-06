using System;

namespace Event01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.listHandlers = new Car.CarEngineHandler(CallWhenExploded);
            car.Accelerate(10);

            car.listHandlers = new Car.CarEngineHandler(CallHereToo);
            car.Accelerate(10);

            car.listHandlers.Invoke("hee");
        }

        static void CallWhenExploded(string msg)
        {
            Console.WriteLine(msg);
        }

        static void CallHereToo(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);
        bool carIsDead = false;
        public int CurrentSpeed;
        public int MaxSpeed = 100;

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public CarEngineHandler listHandlers;

        public void Accelerate(int delta)
        {
            if (listHandlers != null)
                listHandlers("Sorry");
            if(carIsDead)
            {
              
            }
            else
            {
                CurrentSpeed += delta;
                if(10 == MaxSpeed - CurrentSpeed && AboutToBlow != null)
                {
                    AboutToBlow("Be Careful");
                }

                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine(CurrentSpeed);
            }

            
        }
    }
}
