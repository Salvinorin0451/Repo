using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Delegate02
{
    class Program
    {
        public delegate void ab();
        static void Main(string[] args)
        {
            ab ab2 = new ab(Meth);
            ab2 += Meth2;
            ab2 += Meth3;

            List<System.Delegate> multicasts = ab2.GetInvocationList().ToList<System.Delegate>();
            Console.WriteLine(multicasts.Count);

            

            foreach(MulticastDelegate ca in multicasts)
            {
                 
            }

            Console.WriteLine("Hello World!");
        }

        static void Meth()
        {
            Console.WriteLine("123");
        }

        static void Meth2()
        {
            Console.WriteLine("444");
        }

        static void Meth3()
        {
            Console.WriteLine("555555");
        }
    }

    
}
