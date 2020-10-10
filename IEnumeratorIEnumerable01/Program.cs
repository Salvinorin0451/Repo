using System;
using System.Collections;

//Троелсон 326
//IEnumerable и IEnumerator
namespace IEnumeratorIEnumerable01
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            IEnumerable enumerable = garage.GetTheCars(true);
            foreach(Car car in enumerable)
            {
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine(enumerable.GetType().ToString());
        }
    }

    public class Car
    {

    }

    public class Garage  : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car();
            carArray[1] = new Car();
            carArray[2] = new Car();
            carArray[3] = new Car();
        }

        public IEnumerable GetTheCars(bool returnReversed)
        {
            return actualImplementation();

            IEnumerable actualImplementation()
            {
                if(returnReversed)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];
                    }
                }
                else
                    foreach(Car c in carArray)
                    {
                        yield return c;
                    }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }

    public class Garage2 : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage2()
        {
            carArray[0] = new Car();
            carArray[1] = new Car();
            carArray[2] = new Car();
            carArray[3] = new Car();
        }

        public IEnumerator GetEnumerator()
        {
            throw new Exception("This won't get called");
            return actualImplementation();

            IEnumerator actualImplementation()
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
    }
}
