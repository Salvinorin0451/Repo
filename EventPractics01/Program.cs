using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace EventPractics01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vivi vivi = new Vivi();
            Didi didi = new Didi();
            Riri riri = new Riri();

        
            didi.Explode += Method01;

            riri.Explode += Method02;
            Console.WriteLine(didi.EventExplode());
            riri.EventExplode();
        }

        static double Method01(int i)
        {
            return i / 2;
        }

        static void Method02()
        {
            Console.WriteLine("Method2");
        }
    }

    class Riri
    {
        public event Action Explode;

        public Riri()
        {
            Explode = Method01;
        }

        public void EventExplode()
        {
            Explode();
        }

        public void Method01()
        {
            Console.WriteLine("Method01");
        }
    }

    class Didi
    {
        public event Func<int, double> Explode;

        public Didi()
        {
            Explode = Method01;
        }

        public double Method01(int i)
        {
            return Math.Sqrt(i);
        }

        public double EventExplode()
        {
            return Explode(44);
        }
    }

    class Bibi
    {
        public event EventHandler Bang;

        public Bibi()
        {
            Bang = Method01;
        }

        public void Method01(object obj, System.EventArgs e)
        {
            Console.WriteLine("BANG!");
        }
    }


    class Vivi
    {
        public delegate void DelegateVivi();
        public delegate double DelegateViviWithArgs(int i);

        public DelegateVivi vivi = new DelegateVivi(Method01);
        public DelegateVivi vivi2;

        public DelegateViviWithArgs vivi3 = new DelegateViviWithArgs(Method02);
        public DelegateViviWithArgs vivi4;

        public Vivi()
        {
            vivi2 = new DelegateVivi(Method02);
            vivi4 = new DelegateViviWithArgs(Method03);
        }

        public static void Method01()
        {
            
        }

        public static double Method02(int i)
        {
            return Math.Sqrt(i);
        }

        public double Method03(int i)
        {
            return Math.Sqrt(i);
        }

        public void Method02()
        {

        }
    }
}
