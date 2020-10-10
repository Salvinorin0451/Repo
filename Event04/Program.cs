using System;

namespace Event04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void CarAboutBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine($"{sender}, {e.msg}");
        }
    }

    class CarEventArgs : EventArgs
    {
        public readonly string msg;
        public bool isDead = true;

        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler Careful;

        public CarEventArgs(string message)
        {
            msg = message;
        }

        public void Accelerate(int curr)
        {
            if(isDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Boom!"));
            }
        }
    }
}
