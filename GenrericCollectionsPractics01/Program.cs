using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;

namespace GenrericCollectionsPractics01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Person> people = new Stack<Person>();
            Queue<Person> people1 = new Queue<Person>();
            List<Person> people2 = new List<Person>();
            Dictionary<string, Person> people3 = new Dictionary<string, Person>();
            LinkedList<Person> people4 = new LinkedList<Person>();
            SortedList<string, Person> people5 = new SortedList<string, Person>();
            SortedSet<Person> people6 = new SortedSet<Person>();

            SortedSetCollection();
        }

        static void StackCollection()
        {
            Stack<Person> people = new Stack<Person>();

            people.Push(new Person { Name = "Alex", LastName = "Johnson", Age = 20 });
            people.Push(new Person { Name = "JC", LastName = "Denton", Age = 33 });
            people.Push(new Person { Name = "Alex", LastName = "Denton", Age = 33 });
            people.Push(new Person { Name = "Paul", LastName = "Denton", Age = 38 });

            foreach(Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("Peek");
            Console.WriteLine(people.Peek().Name);

            Console.WriteLine("Pop");
            Console.WriteLine(people.Pop().Name);
            Console.WriteLine(people.Pop().Name);
            Console.WriteLine(people.Pop().Name);

            Console.WriteLine("Peek");
            Console.WriteLine(people.Peek().Name);

            Console.WriteLine("Foreach");
            foreach(Person person1 in people)
            {
                Console.WriteLine(person1.Name);
            }
        }

        static void QueueColection()
        {
            Queue<Person> people = new Queue<Person>();

            people.Enqueue(new Person() { Name = "JC", LastName = "Denton", Age = 33 });
            people.Enqueue(new Person() { Name = "Paul", LastName = "Denton", Age = 30 });
            people.Enqueue(new Person() { Name = "Alex", LastName = "Denton", Age = 28 });
            people.Enqueue(new Person() { Name = "John", LastName = "Jackson", Age = 22 });

            foreach(Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("Dequeue");

            Console.WriteLine(people.Dequeue().Name);
            Console.WriteLine(people.Dequeue().Name);

            Console.WriteLine("Peek");

            Console.WriteLine(people.Peek().Name);
        }

        static void ListCollection()
        {
            List<Person> people = new List<Person>();

            people.AddRange(new Person[]
            {
                new Person() {Name = "JC", LastName = "Denton", Age =30},
                new Person() {Name = "Alex", LastName = "Denton", Age = 24},
                new Person() {Name = "Paul", LastName = "Denton", Age = 21}
            });

            people.Add(new Person() { Name = "Jack", LastName = "Johnson", Age = 18 });

            for(int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].Name);
            }

            Person[] personArray = people.ToArray();
            Console.WriteLine("ToArray");

            foreach(Person person in personArray)
            {
                Console.WriteLine(person.Name);
            }
        }

        static void Dictionary()
        {
            Dictionary<string, Person> keyValuePairs = new Dictionary<string, Person>();

            keyValuePairs.Add("Alex-Key", new Person() { Name = "Alex", LastName = "Denton", Age = 30 });
            keyValuePairs.Add("JC-Key", new Person() { Name = "JC", LastName = "Denton", Age = 30 });
            keyValuePairs.Add("Paul-Key", new Person() { Name = "Paul", LastName = "Denton", Age = 22 });

            Console.WriteLine(keyValuePairs["JC-Key"].Name);
            Console.WriteLine(keyValuePairs["Paul-Key"]);

            Console.WriteLine("Values from foreach");

            foreach(Person person in keyValuePairs.Values)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("Keys from foreach");

            foreach(string person1 in keyValuePairs.Keys)
            {
                Console.WriteLine(person1);
            }
        }

        static void LinkedListCollection()
        {
            LinkedList<Person> people = new LinkedList<Person>();
            people.AddLast(new Person() { Name = "Paul", LastName = "Denton", Age = 34 });
            people.AddLast(new Person() { Name = "JC", LastName = "Denton", Age = 28 });
            people.AddFirst(new Person() { Name = "Alex", LastName = "Denton", Age = 23 });
            


        }

        static void SortedListCollection()
        {
            SortedList<string, Person> keyValuePairs = new SortedList<string, Person>();

            keyValuePairs.Add("Alex-Key", new Person() { Name = "3Alex", LastName = "Denton", Age = 19 });
            keyValuePairs.Add("JC-Key", new Person() { Name = "2JC", LastName = "Denton", Age = 24 });
            keyValuePairs.Add("Paul-Key", new Person() { Name = "4Paul", LastName = "Denton", Age = 30 });

            
            foreach(Person c in keyValuePairs.Values)
            {
                Console.WriteLine(c.Name);
            }

            foreach(string ca in keyValuePairs.Keys)
            {
                Console.WriteLine(ca);
            }

        }

        static void SortedSetCollection()
        {
            SortedSet<Person> people = new SortedSet<Person>();

            people.Add(new Person() { Name = "Alex", LastName = "Denton", Age = 32 });
            people.Add(new Person() { Name = "01", LastName = "Adnt", Age = 20 });
            people.Add(new Person() { Name = "BB", LastName = "1", Age = 22 });
            people.Add(new Person() { Name = "Al", LastName = "222", Age = 30 });
            people.Add(new Person() { Name = "babaa", LastName = "Aleale", Age = 33 });

            foreach(Person person in people)
            {
                Console.WriteLine(person.Name);
            }
        }

    }

    class Person : IComparable
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            return String.Compare(Name, ((Person)obj).Name);
        }
    }
}
