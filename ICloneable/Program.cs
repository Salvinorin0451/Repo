using System;

namespace ICloneable01
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3, "NameName");
            Point point2 = new Point(5, 5, "Nakafaka");
            point2 = (Point)point1.Clone();
            Console.WriteLine($"{point1.X} {point1.Y} {point1.desc.PetName} {point1.desc.PointID}");
            Console.WriteLine($"{point2.X} {point2.Y} {point2.desc.PetName} {point2.desc.PointID}");

            Console.WriteLine("Hello World!");
        }
    }

    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }

        public PointDescription()
        {
            PetName = "No-name";
            PointID = Guid.NewGuid();
        }
    }

    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point() { }
        public Point(int xPos, int yPos, string petName) { X = xPos; Y = xPos; desc.PetName = petName; }
        public Point(int xPos, int yPos, string petName, Guid guid) { X = xPos; Y = yPos; desc.PetName = petName; desc.PointID = guid; }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }

        public override string ToString()
        {
            return $"X = {X}; Y = {Y}; Name = {desc.PetName}; ID = {desc.PointID}";
        }

        public object Clone()
        {
            return new Point(this.X, this.Y, this.desc.PetName, this.desc.PointID);
        }
    }
}
