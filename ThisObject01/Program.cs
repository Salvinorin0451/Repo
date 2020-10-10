using System;

namespace ThisObject01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.MethodField1("A")
                .MethodField2("B")
                .MethodField3("C")
                .MethodField4("D")
                .MethodField5("E")
                .Show();

            Console.WriteLine("Hello World!");
        }
    }

    class Car
    {
        private string Field1 { get; set; }
        private string Field2 { get; set; }
        private string Field3 { get; set; }
        private string Field4 { get; set; }
        private string Field5 { get; set; }

        public void Show()
        {
            var a = (Field1, Field2, Field3, Field4, Field5);
            Console.WriteLine(a);
        }

        public Car MethodField1(string a)
        {
            Field1 = a;
            return this;
        }

        public Car MethodField2(string b)
        {
            Field2 = b;
            return this;
        }

        public Car MethodField3(string a)
        {
            Field3 = a;
            return this;
        }

        public Car MethodField4(string a)
        {
            Field4 = a;
            return this;
        }

        public Car MethodField5(string a)
        {
            Field5 = a;
            return this;
        }
    }
}
