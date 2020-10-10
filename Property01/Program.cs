using System;

namespace Property01
{
    //Троелсон 227
    //Свойства, сжатые до выражений
    class Program
    {
        int empAge;
        public int Age
        {
            get => empAge;
            set => empAge = value;
        }

        //Троелсон 233
        //Инициализация автоматических свойств
        //Присваивание автоматическим свойствам начальных значений
        public int NymberOfCars { get; set; } = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
