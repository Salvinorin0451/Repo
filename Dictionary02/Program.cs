using System;
using System.Collections.Generic;

namespace Dictionary02
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDictionary();
            
        }

        static void UseDictionary()
        {
            Dictionary<string, Person> pairs = new Dictionary<string, Person>()
            {
                {"Lisa", new Person(){ FirstName = "Lisa", LastName = "Denton", Age = 16} },
                {"Alex", new Person(){FirstName = "Alex", LastName = "Denton", Age = 18} },
                {"John", new Person(){FirstName = "John", LastName = "Denton", Age = 19} },
                {"Paul", new Person(){FirstName = "Paul", LastName = "Detnon", Age = 17} }
            };

            Dictionary<string, Person> pairs1 = new Dictionary<string, Person>()
            {
                ["Lisa"] = new Person() { FirstName = "Lisa-1", LastName = "Denton-1", Age = 20 },
                ["Alex"] = new Person() { FirstName = "Alex-1", LastName = "Denton-1", Age = 21 },
                ["John"] = new Person() { FirstName = "John-1", LastName = "Denton-1", Age = 22 }
            };

            Person person = pairs1["Lisa"];

            foreach(Person person1 in pairs1.Values)
            {
                Console.WriteLine(person1.FirstName + " " + person1.LastName);
            }

        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
