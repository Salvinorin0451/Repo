using System;

namespace BaseCtor01
{
    //Троелсон 250
    //Управление созданием объектов базового класса с помощью ключевого слова base
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }

        public Employee(int age, int id, string name)
        {
            Age = age;
            ID = id;
            Name = name;
        }
    }

    class Manager : Employee
    {
        public float CurPay { get; set; }
        public string SSN { get; set; }

        public Manager(int age = 21, int id = 0, string name = "", string ssn = "", float curpay = 10)
            :base(age,id,name)
        {
            CurPay = curpay;
            SSN = ssn;
        }
    }

    class SalesPerson : Employee
    {
        public string EmpID { get; set; }
        public int Sales { get; set; }
        public SalesPerson(int age = 21, int id = 0, string name = "", int sales = 0, string empid = "")
            :base(age,id,name)
        {
            EmpID = empid;
            Sales = sales;
        }
    }
}
