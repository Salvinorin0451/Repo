using System;

//Троелсон 207
//Еще раз о необязательных аргументах
namespace CtorsWithNonNesseseryArguments01
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle(name: "namenamename");
            Console.WriteLine("Hello World!");
        }
    }

    class Motorcycle
    {
        int driverIntensity;
        string driverName;
        public Motorcycle(int intensity = 0, string name = "")
        {
            if(intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
