using System;
//Троеслон 190
//Кортежи (нововведение)
namespace Cortages01
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, int, string) values = ("4", 5, "df");
            var values2 = ("4", 4, "fjkds", 4);
            (string FirstLetter, int TheNumber, string SecondLetter)
                valuesWithNames = (FirstLetter: "kfjsdl", TheNumber: 4, SecondLetter: "dfkk");

            /*
             К каждому свойству кортежа можно также добавлять специфическое имя либо в правой, либо в левой
            части оператора. Хотя назначение имен в обеих частях оператора не приводит к ошибке на этапе компиляции, имена
            в правой части игнорируются, а использоваться будут имена в левой части.
            */
            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");

            //Теперь доступ к свойствам кортежа возможен с применением имен полей, а также системы обозначений ItmX:

            Console.WriteLine($"1 - {valuesWithNames.Item1}");
            Console.WriteLine($"2 - {valuesWithNames.Item2}");
            Console.WriteLine($"3 - {valuesWithNames.Item3}");

            Console.WriteLine("");
            Console.WriteLine("");
            Tuples();


            Console.WriteLine("Hello World!");
        }

        /*Чтобы создать кортеж, просто поместите значения, подлежащие присваиванию, 
         * в круглые скобки: { "a", 5, "c"} 
         Все значения не обязаны относиться к тому же самому типу данных. Конструкция 
        с круглыми скобками также применяется для присваивания кортежа переменной. Или 
        можно использовать коючевое слово var и тогда компилятор назначит типы данных
        самостоятельно. Показанные далее две строки кода делают одно и то же - присваивают
        предыдущий пример кортежа переменной. Переменная values будет кортежем с двумя свойствами
        string и одном свойством int*/


        static void Tuples()
        {
            (int, int, int) Tuples = (4, 4, 4);
            (int, int, int) Value = (5, 5, 5);

            var VarTuples = ("asd", "asd", 43, 4.3);

            var VariableTuples = (f1: 4, f2: 5, 5.4, 55.5);

            (int f1, int f2, int f3) Ttup = (4, 3, 2);
            (int f4, int f5, int f6) Tuptup = (44, 2, 2);

            Console.WriteLine(Tuples.Item1);
            Console.WriteLine(Value.Item3);
            Console.WriteLine(VarTuples.Item1);
            Console.WriteLine(VariableTuples.Item1);
            Console.WriteLine(VariableTuples.f1);
            Console.WriteLine(Ttup.f3);
            Console.WriteLine(Ttup.Item2);
            Console.WriteLine(Tuptup.f6);
            Console.WriteLine(Tuptup.Item2);
            Console.WriteLine(Tuptup.Item3);

            Console.WriteLine(Tuptup.GetType());


        }
    }
}
