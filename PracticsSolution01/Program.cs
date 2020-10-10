using System;

namespace PracticsSolution01
{
    class Program
    {
        static Car[] garage = new Car[3];

        static void Main(string[] args)
        {
            garage[0] = new Car(new V8(4, "4", "4"));
            Car car = new Car
            {
                Engine = new Engine { abc = "", field1 = 4}
        };
   
            Console.WriteLine("Hello World!");
        }
    }

    class Car
    {
        public Engine Engine { get; set; }
        public Car(Engine engine)
        {
            Engine = engine;
        }

        public Car()
        {

        }
    }

    class Engine
    {
        public int field1;
        public string abc;

        public (int Field1, int Field2, int Field3) ABC = (5, 5, 5);

        public Engine(int a, string b)
        {
            field1 = a;
            abc = b;
        }
          public Engine()
          {

         }

        public byte Method()
        {
            return checked((byte)field1);
        }

        public (int,int,int) MethodTuples()
        {
            return (ABC.Field1, 4, 4);
        }
    }

    class V8 : Engine
    {
        public string id;
        public V8(int a, string b, string c)
            :base (a, b)
        {
            id = c;
        }
    }

}
