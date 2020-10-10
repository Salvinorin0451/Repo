using System;

namespace IComparable02
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4];
            cars[0] = new Car("BMW", 2, new Guid());
            cars[1] = new Car("Toyota", 5, new Guid());
            cars[2] = new Car("Honda", 1, new Guid());
            cars[3] = new Car("Suzuki", 5, new Guid());

            Array.Sort(cars);

            int a = String.Compare("aaab", "aaac");
            Console.WriteLine(a);

            foreach(Car car in cars)
            {
                car.Show();
            }
      

            Console.WriteLine("Hello World!");
        }
    }

    class Car : IComparable
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public int Number { get; set; }

        public Car(string name, int number, Guid id)
        {
            Name = name;
            Id = id;
            Number = number;
        } 
        
        public void Show()
        {
            Console.WriteLine($"{Name} {Number}          {Id}");
        }

        public int CompareTo(object obj)
        {
            Car car = obj as Car;
            return String.Compare(this.Name, car.Name);
        }
    }
}
