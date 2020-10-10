using System;
using System.Collections;

namespace IEnumeratorIEnumerable02
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage3 garage = new Garage3();
            foreach(Car car in garage)
            {
               // Console.WriteLine(car.field);
            }
            Console.WriteLine("Hello World!");
        }
    }

    class Garage3 : IEnumerable
    {
        Car[] cars = new Car[5];

        public Garage3()
        {
            for(int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car("Car - " + i);
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Car c in cars)
            {
                Console.WriteLine(c.field);
                yield return c;
            }
        }
    }

    class Garage : IEnumerable
    {
        Car[] cars = new Car[5];

        

        public Garage()
        {
            for(int i =0; i < cars.Length; i++)
            {
                cars[i] = new Car("Cars + " + i);
            }
        }

        public IEnumerator GetEnumerator()
        {
             foreach(Car car in cars)
            {
                Console.WriteLine(car.field);
                yield return car;
            }
        }
    }

    class Car
    {
        public string field;

        public Car(string field)
        {
            this.field = field;
        }
    }
}
