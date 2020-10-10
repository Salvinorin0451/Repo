using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Cache;

//Троелсон 362
//Работа с классом Stack<T>

/* Класс Stack<T> - представляет коллекцию элементов, которая обслуживает элементы в стиле 
 * "последний вошел - первый вышел" (LIFO). Как и можно было ожидать, в Stack<T> определены
 * члены Push() и Pop(), предназначенные для вставки и удаления элементов из стека.
 */

namespace StackGeneric01
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericStack();
            UseGenericStack();
            Console.WriteLine("Hello World!");
        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();

            stackOfPeople.Push(new Person() { Name = "A", LastName = "B", Age = 30 });
            stackOfPeople.Push(new Person() { Name = "A1", LastName = "B1", Age = 31 });
            stackOfPeople.Push(new Person() { Name = "A2", LastName = "B2", Age = 32 });
            stackOfPeople.Push(new Person() { Name = "A3", LastName = "B3", Age = 33 });
            stackOfPeople.Push(new Person() { Name = "A4", LastName = "B4", Age = 34 });

            foreach(Person person in stackOfPeople)
            {
                Console.WriteLine(person.Name + " " + person.LastName);
            }

            //Peak() - посмотреть элемент, находящийся на вершине стека
            Console.WriteLine("Peak invite");
            Console.WriteLine(stackOfPeople.Peek().Name + " " + stackOfPeople.Peek().LastName);
            Console.WriteLine(stackOfPeople.Peek().Name + " " + stackOfPeople.Peek().LastName);
            Console.WriteLine(stackOfPeople.Peek().Name + " " + stackOfPeople.Peek().LastName);

            //Pop() - каждый вызов этого метода удаляет верхний элемент стека
            Console.WriteLine("Pop invite");
            Console.WriteLine(stackOfPeople.Pop().Name + " " + stackOfPeople.Pop().LastName);
            Console.WriteLine(stackOfPeople.Pop().Name + " " + stackOfPeople.Pop().LastName);
        }


    }    

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
