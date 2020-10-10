using System;
using System.Collections;

namespace IComparable03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];

            for(int i = 0; i< cars.Length; i++)
            {
                cars[i] = new Car("Name" + i);
            }

            Array.Sort(cars);

            foreach(Car car in cars)
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine("Hello World!");
        }
    }

    class Car : IComparable
    {
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            return String.Compare(((Car)obj).Name, Name);
        }

        public Car(string name)
        {
            Name = name;
        }
    }
}
