using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rectangle RectangleOne = new Rectangle(4, "RectangleOne");
            RectangleOne.SetArea(5);
        }
    }
}
