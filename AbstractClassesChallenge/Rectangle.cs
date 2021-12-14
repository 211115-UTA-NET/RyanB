using System;

namespace AbstractClassesChallenge
{
     class Rectangle : TwoDimensionalShape
    {
        // Implement your Square Class here.
        public Rectangle() {

        }

        public override double SetArea()
        {
            Console.WriteLine("RECTANGLE: How Precise Is Your Length?");
            double Length = Console.ReadLine();

            Console.WriteLine("RECTANGLE: How Precise Is Your Width?");
            double Width = Console.ReadLine();
            this.Area = (Length*Width);
            // this.Area
        }

        public override string ToString()
        {
            return string.Format("Rectangle") + base.ToString();
        }
    }
}
