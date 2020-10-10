using System;

//Троелсон 335
//Интерфейс IComparable
namespace IComparable01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] myAutos = new Car[5];
            for(int i=0; i<myAutos.Length; i++)
            {
                myAutos[i] = new Car("name" + (myAutos.Length - i), i + 20, i + 1);
            }
            myAutos[0] = new Car("sdfjkh", 0, 0);
            myAutos[1] = new Car("asssa", 0, 0);
            myAutos[2] = new Car("assaa", 0, 0);
            myAutos[3] = new Car("sdjkj", 0, 0);
            myAutos[4] = new Car("dklgsljadgs", 0, 0);
            foreach (Car c in myAutos)
            {
                Console.WriteLine(c.Name);
            }

            Array.Sort(myAutos);


            foreach(Car c in myAutos)
            {
                Console.WriteLine(c.Name);
            }
            Console.WriteLine("Hello World!");
        }
    }

    public class Car : IComparable
    {
        public int currSp { get; set; }
        public string Name { get; set; }
        public int CarID { get; set; }
        public Car(string name = "name", int currSp = 0, int id = 0)
        {
            this.currSp = currSp;
            this.Name = name;
            this.CarID = id;
        }

        public int CompareTo(object obj)
        {
            
            char[] tempArray = this.Name.ToCharArray();
            char[] objArray = ((Car)obj).Name.ToCharArray();

            return Recurse(0);

            int Recurse(int i)
            {
                int temp1 = 0;
                if ((i <= tempArray.Length - 1) && (i <= objArray.Length - 1))
                {
                    if (tempArray[i] == objArray[i])
                    {
                        temp1 = Recurse(i + 1);
                    }
                    if (tempArray[i] > objArray[i])
                    {
                        temp1 = 1;
                    }
                    if (tempArray[i] < objArray[i])
                    {
                        temp1 = -1;
                    }
                }
                return temp1;
            }
        }
    }
}
