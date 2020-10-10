using System;
using System.Collections;


/*  ArrayList - ПРедоставляет коллекцию с динамически изменяемым размером,
 *  выдающую объекты в последовательном порядке
 *  BitArray - Управляет компактным массивом битовых значений, которые представляются
 *  как булевские, где true обозначает установленный (1) бит, а false - неустановленный (0) бит
 *  Hashtable - Представляет коллекцию пар "ключ-значение", организованных на основе хеш кода ключа
 *  Queue - Представляет стандартную очередь объектов, работающую по принципу FIFO ("первый вошел - первый вышел")
 *  SortedList - Представляет коллекцию пар "ключ-значение", отсортированных по ключу и доступных по ключу и по индексу
 *  Stack - Представляет стек LIFO ("последний вошел - первый вышел"), поддерживающий функциональность заталкивания и выталкивания, а также считывания
 */

/* ICollection - Определяет общие характеристика (например, размер, перечисление ибезопасность к потокам) для всех необобщенных
 * типов коллекций
 * ICloneable - Позволяет реализующему объекту возвращать вызывающему коду копию самого себя
 * IDictionary - Позволяет объекту необобщенной коллекции представлять свое содержимое в виде пар "ключ-значение"
 * IEnumerable - Возвращает объект, реализующий интерфейс IEnumerator
 * IEnumerator - Делает возможной итерацию в стиле foreach по элементам коллекции
 * IList - Обеспечивает поведение добавления, удаления и индексирования эдементов в последовательном списке объектов
 */
namespace SystemCollection01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList strArray = new ArrayList();
            //AddRange принимает в качестве аргумента объект реализующий интерфейст ICollection
            strArray.AddRange(new string[] { "123", " ", "456", " ", "789" });

            //BitArray
            BitArray bitArray = new BitArray(new bool[] {true, false, false });
            BitArray bitArray1 = new BitArray(new byte[] { 3,1,255 });
            //Содержит двоичные значения, скопированные из указанного массива
            BitArray bitArray2 = new BitArray(new int[] { 5 });
            //Содержит указанное количество битов с первоначально заданным значение false
            BitArray bitArray3 = new BitArray(10);
            //
            BitArray bitArray4 = new BitArray(10, true);


            Hashtable hashtable = new Hashtable();
            hashtable.Add("A", "1");
            hashtable.Add("B", "2");
            //hashtable.Add("B", "5"); - дает исключение
            foreach(string collection in hashtable.Keys)
            {
                Console.WriteLine(collection);
            }

            foreach(string dictionary in hashtable.Keys)
            {
                Console.WriteLine($"{dictionary} {hashtable[dictionary]}");
            }
            //Queue
            Queue queue = new Queue();
            queue.Enqueue("A1");
            queue.Enqueue("A2");
            queue.Enqueue("A3");
            queue.Enqueue("A4");
            foreach(string a in queue)
            {
                Console.WriteLine(a);
            }

            SortedList sortedList = new SortedList();
            sortedList.Add("Key1", "Value1");
            sortedList.Add("Key2", "Value2");
            sortedList.Add("Key3", "Value3");

            ICollection aColl = sortedList.Values;

            foreach(string an in aColl)
            {
                Console.WriteLine(an);
            }

            foreach(string collection1 in sortedList.Values)
            {
                Console.WriteLine(collection1);
            }

            foreach(string item in sortedList.Keys)
            {
                Console.WriteLine($"{item} {sortedList[item]}");
            }

            Stack stack = new Stack();
            stack.Push("string");
            stack.Push("value1");
            stack.Push("value2");
            stack.Push("value3");

            foreach(string aaa in stack)
            {
                Console.WriteLine(aaa);
            }

            string stringValue = (string)stack.Pop();
            Console.WriteLine(stringValue);

            Console.WriteLine("__________________________");
            foreach(string aaa in stack)
            {
                Console.WriteLine(aaa);
            }

            Show(bitArray2);


            Console.WriteLine("Hello World!");
        }

        static void Show(IEnumerable a)
        {
            int i = 8;

            foreach(bool collection in a)
            {
                if (i <= 0)
                {
                    Console.WriteLine();
                    i = 8;
                }
                i = i - 1;
                Console.Write("{0,8} ",collection);
            }
        }
    }


}
