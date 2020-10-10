using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

//Троелсон 366

namespace Dictionary01
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void UseDictionary()
        {
            Dictionary<string, Person> keyValuePairs = new Dictionary<string, Person>();

            keyValuePairs.Add("Homer", new Person
            {
                FirstName = "Homer",
                LastName = "Simpson",
                Age = 47
            });

            keyValuePairs.Add("Marge", new Person
            {
                FirstName = "Marge",
                LastName = "Simpson",
                Age = 45
            });

            keyValuePairs.Add("Lisa", new Person
            {
                FirstName = "Lisa",
                LastName = "Simpson",
                Age = 9
            });

            Person person = keyValuePairs["Homer"];
            Console.WriteLine(person);

            Dictionary<string, Person> people1 = new Dictionary<string, Person>()
            {
                {"Homer", new Person {FirstName = "Homer", LastName = "Simpson", Age = 47} },
                {"Marge", new Person {FirstName = "Marge", LastName = "Simpson", Age = 45} },
                {"Lisa",  new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9} }
            };

            Person lisa = people1["Lisa"];
            Console.WriteLine(lisa);

            Dictionary<string, Person> people2 = new Dictionary<string, Person>()
            {
                ["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                ["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                ["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }
            };
        }
    }
    
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
