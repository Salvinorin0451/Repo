using System;
using System.Collections.Generic;

//Троелсон 364
//Работа с классом Queue<T>

/* Очереди - это контейнеры, которые обеспечивают доступ к элементам в манере
 * "первый вошел - первый вышел" (FIFO)
 * 
 * Dequeue() - Удаляет и возвращает объект из начала Queue<T>
 * 
 * Enqueue() - Добавляет объект в конце Queue<T>
 * 
 * Peek() - Возвращает объект из начала Queue<T>, не удаляя его
 * 
 */
namespace QueueGeneretic01
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericQueue();
            Console.WriteLine("Hello World!");
        }

        static void UseGenericQueue()
        {
            Queue<Person> people = new Queue<Person>();
            people.Enqueue(new Person { Name = "A1", LastName = "B1", Age = 30 });
            people.Enqueue(new Person { Name = "A2", LastName = "B2", Age = 31 });
            people.Enqueue(new Person { Name = "A3", LastName = "B3", Age = 32 });
            people.Enqueue(new Person { Name = "A4", LastName = "B4", Age = 33 });
            people.Enqueue(new Person { Name = "A5", LastName = "B5", Age = 34 });

            foreach(Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("_____________________________________________");

            people.Dequeue();
            people.Dequeue();
            people.Dequeue();

            foreach(Person person1 in people)
            {
                Console.WriteLine(person1.Name);
            }
            
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
