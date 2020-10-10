using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

//Троелсон 364

namespace SortedSetCollection01
{
    class Program
    {
        static void Main(string[] args)
        {
            UseSortedSet();
            Console.WriteLine("Hello World!");
        }

        static void MethodBySortedCollection()
        {

        }

        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {Name = "Homer", LastName = "Simpson", Age = 47},
                new Person {Name = "Marge", LastName = "Simpson", Age = 45},
                new Person {Name = "Lisa", LastName = "Simpson", Age = 9},
                new Person {Name = "Bart", LastName = "Simpson", Age = 8}
            };

            foreach(Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            setOfPeople.Add(new Person
            {
                Name = "Saku",
                LastName = "Jones",
                Age = 1
            });
            setOfPeople.Add(new Person
            {
                Name = "Mikko",
                LastName = "Jones",
                Age = 32
            });

            foreach(Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }

        }
    }

    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            if(firstPerson?.Age > secondPerson?.Age)
            {
                return 1;
            }
            if(firstPerson?.Age < secondPerson?.Age)
            {
                return -1;
            }
            return 0;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName} {Age}";
        }
    }
}
