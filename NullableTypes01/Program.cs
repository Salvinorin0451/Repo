using System;

namespace NullableTypes01
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseReader dr = new DatabaseReader();

            //Если значение, возвращаемое из GetintFromDatabase(), равно
            //null, то присвоть локалльной переменной значение 100
            int myData = dr.GetIntFromDatabase() ?? 100;

            Console.WriteLine(myData);
            Console.WriteLine("Hello World!");
        }

        static void NullableType()
        {
            int? nullableInt = 10; ;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullablInts = new int?[10];


        }
    }

    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;

        //Не присваивает значчение члену целочисленного типа
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        //Присваивает допустимое значение члену типа bool?
        public bool? GetBoolFromDatabase()
        {
            return boolValue; 
        }

    }
}
