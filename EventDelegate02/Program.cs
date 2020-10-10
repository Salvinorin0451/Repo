using System;

namespace EventDelegate02
{
    class Program
    {
        static void Main(string[] args)
        {
            Wewe wewe = new Wewe();
            Ququ ququ = new Ququ();

            wewe.ActivateEvent("Wee1");
            ququ.action("Delegate1");

            wewe.eventAction += ququ.action;
            wewe.ActivateEvent("Piypiy");

            wewe.eventAction += Method01;
            wewe.ActivateEvent("wewewe1");

            ququ.action += wewe.ActivateEvent;
            ququ.action("ququ Activate");
        }

        static void Method01(string arg)
        {
            Console.WriteLine(arg + " From Main");
        }
    }

    class Wewe
    {
        public event Action<string> eventAction;
        public Wewe()
        {
            eventAction = Method01;
        }

        public void Method01(string arg)
        {
            Console.WriteLine(arg + " from Method01 Wewe");
        }

        public void ActivateEvent(string arg)
        {
            eventAction(arg);
        }
    }

    class Ququ
    {
        public Action<string> action;
        public Ququ()
        {
            action = Method01;
        }

        public void Method01(string arg)
        {
            Console.WriteLine(arg + " from Method01 Ququ");
        }
    }
}
