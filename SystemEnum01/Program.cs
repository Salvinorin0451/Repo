using System;

//Троелсон 174
//Тип System Enum
namespace SystemEnum01
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpType emp = EmpType.Contracrot;
            Console.WriteLine($"{Enum.GetUnderlyingType(emp.GetType())}");
            Console.WriteLine($"{emp.GetType()}");
            Show();
            Console.WriteLine("Hello World!");
        }

        enum EmpType : byte
        {
            Manager = 120,
            Grunt,
            Contracrot,
            VicePresident
        }

        static void Show()
        {
            EmpType emp = EmpType.Contracrot;
            Console.WriteLine($"{emp} {(byte)emp}");
        }
        //Этот метод выводит детали любого перечисления.
        static void ArrayShow(System.Enum e)
        {
            Console.WriteLine("=> information about {0}", e.GetType().Name);
            Console.WriteLine("=> Underllying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

            //Получить все пары "имя-значение" для входного параметра.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members", enumData.Length);
            
        }
    }
}
