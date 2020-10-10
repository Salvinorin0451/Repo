using System;
using System.Collections.ObjectModel;
using System.Linq;

/*  Троелсон 368
 *  Пространство имен System.Collections.ObjectModel
 *  
 *  ObservableCollection<T> - Представляет динамическую коллекцию данных,
 *  которая обеспечивает уведомление при добавлении и удалении элементов, а также
 *  при обновлении всего списка
 *  
 *  ReadOnlyObservableCollection<T> - Представляет версию ObservableCollection<T>,
 *  допускающую только чтение
 * 
 * 
 *  Уникальным класс ObservableCollection<T> - делает тот факт, что он поддерживает событие
 *  по имени CollectionChanged. Указанное событие будет инициироваться каждый раз, когда
 *  вставляется новый элемент, удаляется (или перемещается) существующий элемент либо модифицируется
 *  вся коллекция целиком.
 */
namespace ObservableCollection01
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person {FirstName = "Peter", LastName = "Murphy", Age = 20},
                new Person {FirstName = "Kevin", LastName = "Key", Age = 23 }
            };
            //Привязаться к событию CollectionChanged
            people.CollectionChanged += people_CollectionChanged;

            people.Add(new Person() { FirstName = "Alex", LastName = "Denton", Age = 33 });

            Console.WriteLine("Hello World!");
        }

        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //Входной параметр NotifyCollectionChangedEventArgs определяет два важных свойства
            //OldItems и NewItem, которые выдают список элементов, имеющихся в коллекции перед генерацией
            //события, и список новых элементов, вовлеченных в изменение.
            Console.WriteLine("Yeap!");
            foreach(Person en in e.NewItems)
            {
                Console.WriteLine(en.FirstName);
            }
            /* Чтобы выяснить какое из действий запустило событие, можно использовать свойство
             * Action объекта NotifyCollectionChangedEventArgs. Свойство Action допускается
             * проверять на равенство любому из членов перечисления NotifyCollectionChangedAction
             */
        }

        static void people_CollectionChanged2(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Action for this event: {0}", e.Action);
            
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                foreach (Person person in e.OldItems)
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }


}
