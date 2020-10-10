using System;

namespace Delegate04
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);
        static void Main(string[] args)
        {
            SimpleMath simple = new SimpleMath();
            BinaryOp b = new BinaryOp(simple.Add);
            DislayDelegateInfo(b);
        }

        static void DislayDelegateInfo(Delegate delObj)
        {

            foreach(Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.Target);
            }
        }
    }

    class SimpleMath
    {
        public int Add(int x, int y) => x + y;
    }
}
