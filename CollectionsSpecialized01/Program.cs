using System;
using System.Collections.Specialized;

/*  Троелсон 347
 *  Пространство имен System.Collections.Specialized
 *  
 *  HybridDictionary - этот класс реализует интерфейс IDictionary за счет применения ListDictionary, пока
 *  коллекция мала, и переключения на Hashtable, когда коллекция становится большой
 *  
 *  ListDictionary - Этот класс удобен, когда необходимо управлять небольшим количеством 
 *  элементов (10 или около того), которые могут изменяться с течением времени. Для управления своими
 *  данными класс использует односвязным список
 *  
 *  StringCollection - Этот класс обеспечивает оптимальный способ для управления крупными
 *  коллекциями строковых данных
 *  
 *  BitVector32 - Этот класс предоставляет простую структуру, которая хранит булевские значения и
 *  небольшие целые числа в 32 битах памяти
 * 
 */
namespace CollectionsSpecialized01
{
    class Program
    {
        static void Main(string[] args)
        {
            HybridDictionary hybridDictionary = new HybridDictionary();
            hybridDictionary.Add("Key1", "Value1");
            hybridDictionary.Add("Key2", "Value2");
            hybridDictionary.Add("Key3", "Value3");

            foreach(string item in hybridDictionary.Keys)
            {
                Console.WriteLine($"{item} {hybridDictionary[item]}");
            }

            ListDictionary listDictionary = new ListDictionary();
            listDictionary.Add("Key1", "Value1");
            listDictionary.Add("Key2", "Value2");
            listDictionary.Add("Key3", "Value3");

            foreach(string item in listDictionary.Keys)
            {
                Console.WriteLine($"{item} {listDictionary[item]}");
            }

            StringCollection stringCollection = new StringCollection();
            stringCollection.AddRange(new string[] { "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7" });
            foreach(string item in stringCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stringCollection[3]);
            Console.WriteLine(stringCollection[0]);

            Console.WriteLine("Hello World!");
        }
    }

    class Car
    {
        public string Field1 { get; set; }
        public string Field2 { get; set; }

        public Car()
        {

        }
        public Car(string field1, string field2)
        {
            Field1 = field1;
            Field2 = field2;
        }
    }

}
