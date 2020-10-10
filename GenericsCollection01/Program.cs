using System;
using System.Collections.Generic;
//Троелсон 360
//Классы из пространства имен System.Collections.Generic

/* Интерфейсы
 * ____________________________________________________________
 * ICollection<T>
 * Определяет общие характеристики (например, размер, перечислениеи безопасность к потокам)
 * для всех типов обощенных коллекций
 * 
 * IComparer<T>
 * Определяет способ сравнения объектов
 * 
 * IDictionary<TKey, TValue>
 * Позволяет объекту обощенной коллекции представлять свое содержимое посредством пар 
 * "ключ-значение"
 * 
 * IEmumerable<T>
 * Возвращает интерфейс IEnumerator<T> для заланного объекта
 * 
 * IEnumerator<T> - Позволяет выполнять итерацию в стиле foreach по элементам коллекции
 * 
 * IList<T> - Обеспечивает поведение добавления, удаления и индексации элементов
 * в последовательном списке объектов
 * 
 * ISet<T> - Предоставляет базовый интерфейс для абстракции множеств
 * ____________________________________________________________
 * Классы
 * ____________________________________________________________
 * Dictionary<TKey,TValue> - предоставляет обощенную коллекцию ключей и значений
 * 
 * LinkedList<T> - Представляет двухсвязный список
 * 
 * List<T> - Представляет последовательный список элементов с динамически изменяемым размером
 * 
 * Queue<T> - Обощенная реализация списка, работающего по алгоритму "первый вошел - первый вышел" (FIFO)
 * 
 * SortedDictionary<TKey,TValue> Обощенная реализация сортированного можества пар "ключ-значение"
 * 
 * SortedSet<T> - Представляет коллекцию объектов, поддерживаемых в сортированном порядке без дубликатов
 * 
 * Stack<T> - Обощенная реализация списка, работающего по алгоритму "последний вошел - первый вышел" (LIFO)
 *
 *
 */
namespace GenericsCollection01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person {Name = "Homer", LastName ="Simpson", Age = 47},
                new Person {Name = "Fry", LastName = "Unknows", Age = 25},
                new Person {Name = "Tayler", LastName = "Unknows", Age = 33},
                new Person {Name = "Bary", LastName = "Simpson", Age = 35},
                new Person {Name = "Man", LastName = "Just", Age = 40}
            };

            people.Insert(2,
                new Person { Name = "One", LastName = "Eno", Age = 50 });

            foreach(Person person in people)
            {
                Console.WriteLine(person.Name + " " + person.LastName);
            }
            Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }
    }
}
