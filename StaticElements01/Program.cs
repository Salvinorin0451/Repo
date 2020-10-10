using System;

namespace StaticElements01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class SavingsAccount
    {
        public static double currInterestRate = 0.04;
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }

        public double currBalance;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
    }

    class Savings2Account
    {   //При каждом создании нового объекта этого класса, вызываемый конструктор 
        //обновляет данные статического поля
        public double currBalance;
        public static double currInterestRate;

        public Savings2Account(double balance)
        {
            currInterestRate = 0.04;
            currBalance = balance;
        }
    }

    class Savings3Account
    {
        public double currBalance;
        public static double currInterestRate;

        //В одном классе может быть определен только один единственный конструктор
        //Статический конструктор не может иметь модификаторов доступа
        //Статический конструктор не может принимать аргументы
        //Статический конструктор выполняется только один раз вне зависимости от количества создаваемых объектов заданного класса
        //Статический конструктор вызывается, когда создается экземпляр класса или перед доступом к первому статическому члену из вызывающего кода
        //Статический конструктор выполняется перед любым конструктором уровня экземпляра
        static Savings3Account()
        {
            currInterestRate = 0.4;
        }
    }
}
