using System;

namespace DynamicShapes
{
     class Rectangle : TwoDimensionalShape
    {
        // Implement your Square Class here.
        // private double A;
        // private double Calculate;
        public Rectangle(double A) : base(A) {
            // this.A = A;
            this.Name = "Rectangle";
        }

        // public override double SetArea()
        // {
        //     Console.WriteLine("RECTANGLE: How Precise Is Your Length?");
        //     double Length = Parse(Console.ReadLine());

        //     Console.WriteLine("RECTANGLE: How Precise Is Your Width?");
        //     double Width = Parse(Console.ReadLine());
        //     this = (Length*Width);
        //     // this.Area
        // }
        // private void RecCalculation(){
        //      Console.WriteLine("RECTANGLE: How Precise Is Your Length?");
        //     double Length = double.Parse(Console.ReadLine());

        //     Console.WriteLine("RECTANGLE: How Precise Is Your Width?");
        //     double Width = double.Parse(Console.ReadLine());
        //     Calculate = (Length*Width);
        //     // this.Area = Calculate;
        // }
        protected override double Area
        {
            // get{
            //   Console.WriteLine("RECTANGLE: How Precise Is Your Length?");
            // double Length = double.Parse(Console.ReadLine());

            // Console.WriteLine("RECTANGLE: How Precise Is Your Width?");
            // double Width = double.Parse(Console.ReadLine());
            // return (Length*Width);
            // }
            // get{
            // return this.area;
            // }
            // this.Area
            
            // get{
             
            // return Calculate;
            // }
             get{
            //   Console.WriteLine("RECTANGLE: How Precise Is Your Length?");
            // double Length = double.Parse(Console.ReadLine());

            // Console.WriteLine("RECTANGLE: How Precise Is Your Width?");
            // double Width = double.Parse(Console.ReadLine());
            return (base.SizeOfSides*base.SizeOfSides);
            }
        }

        public override string ToString()
        {
            return string.Format(Name) + base.ToString();
        }
    }
}
