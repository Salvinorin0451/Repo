using System;

//Троелсон 203
//Построение цепочки вызовов конструкторов с использованием this
namespace ThisLinks01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.ShowMe();
            car = new Car("Name");
            car.ShowMe();
            car = new Car(444);
            car.ShowMe();
            car = new Car(2);
            car.ShowMe();
            car = new Car(2, "NameName");
            car.ShowMe();
            car = new Car(22, "Name");
            car.ShowMe();
            Console.WriteLine("Hello World!");
        }
    }

    class Motorcycle //Класс с избыточной логикой конструкторов
    {
        public int driverIntensity;
        public string driverName;

        public Motorcycle() { }

        public Motorcycle(int intensity)
        {
            intensity = NewMethod(intensity);
        }


        public Motorcycle(int intensity, string name)
        {
            intensity = NewMethod(intensity);
        }
        
        private int NewMethod(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            return intensity;
        }

    }

    class MotorcycleThis
    {
        public int driverIntensity;
        public string driverName;

        public MotorcycleThis()
        {

        }

        public MotorcycleThis(int intensity)
            : this(intensity, "")                    //передаем дальше в конструктор с двумя параметрами
        {

        }

        public MotorcycleThis(string name)
            : this(0, name)                          //передаем дальше в конструктор с двумя параметрами
        {

        }

        //Это главный конструктор, выполняющий всю реальную работу
        public MotorcycleThis(int intensity, string name)
        {
            if(intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            driverName = name;
        }


    }

    class Car
    {
        public int Speed;
        public string Name;

        public Car()
            : this(0, "UAZ")
        {
            Console.WriteLine("default");
        }

        public Car(int speed)
            :this (speed, "UAZ")
        {
            Console.WriteLine("Speed ctor");
        }

        public Car(string name)
            :this (0, name)
        {
            Console.WriteLine("Name ctor");
        }

        public Car(int speed, string name)
        {
            if(speed > 10)
            {
                speed = 10;
            }
            Speed = speed;
            Name = name;

            Console.WriteLine("General cror");
        }


        public void ShowMe()
        {
            Console.WriteLine($"{Speed} {Name}");
        }
    }


}
