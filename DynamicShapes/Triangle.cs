using System;

namespace DynamicShapes
{
     class Triangle : TwoDimensionalShape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
            // double a, b, c;
            // private double A;
            // private double Calculate;
            public Triangle(double A) : base(A){
                // this.NumSides = sides;
                // this.Name = name;
                // this.A = A;
                this.Name = "Triangle";
            }

        // public override double SetArea()
        // {
        //    Console.WriteLine("Triangle: How Precise Is Your Side A?");
        //      a = double.Parse(Console.ReadLine());

        //     Console.WriteLine("Triangle: How Precise Is Your Side B?");
        //     b = double.Parse(Console.ReadLine());

        //     Console.WriteLine("Triangle: How Precise Is Your Side C?");
        //     c = double.Parse(Console.ReadLine());

        //     double AllSides = (a+b+c)/2;
        //     this.Area = Math.Sqrt(AllSides * (AllSides - a) *
        //     (AllSides - b) * (AllSides - c));
        // }

        // private void TriCalculation() {
        //     Console.WriteLine("Triangle: How Precise Is Your Side A?");
        //      a = double.Parse(Console.ReadLine());

        //     Console.WriteLine("Triangle: How Precise Is Your Side B?");
        //     b = double.Parse(Console.ReadLine());

        //     Console.WriteLine("Triangle: How Precise Is Your Side C?");
        //     c = double.Parse(Console.ReadLine());

        //     double AllSides = (a+b+c)/2;
        //     // return Math.Sqrt(AllSides * (AllSides - a) *
        //     // (AllSides - b) * (AllSides - c));
        //     Calculate = Math.Sqrt(AllSides * (AllSides - a) *
        //     (AllSides - b) * (AllSides - c));
            
        // }
        protected override double Area
        {
        //     get{
        //    Console.WriteLine("Triangle: How Precise Is Your Side A?");
        //      a = double.Parse(Console.ReadLine());

        //     Console.WriteLine("Triangle: How Precise Is Your Side B?");
        //     b = double.Parse(Console.ReadLine());

        //     Console.WriteLine("Triangle: How Precise Is Your Side C?");
        //     c = double.Parse(Console.ReadLine());

        //     double AllSides = (a+b+c)/2;
        //     return Math.Sqrt(AllSides * (AllSides - a) *
        //     (AllSides - b) * (AllSides - c));
        //     }
        //     get{
        //    return this.area;
        //     }
        // get {
        //    return Calculate;
        // }
             get{
        //    Console.WriteLine("Triangle: How Precise Is Your Side A?");
        //      a = double.Parse(Console.ReadLine());

        //     Console.WriteLine("Triangle: How Precise Is Your Side B?");
        //     b = double.Parse(Console.ReadLine());

        //     Console.WriteLine("Triangle: How Precise Is Your Side C?");
        //     c = double.Parse(Console.ReadLine());

            double AllSides = (base.SizeOfSides+base.SizeOfSides+base.SizeOfSides)/2;
            return Math.Sqrt(AllSides * (AllSides - base.SizeOfSides) *
            (AllSides - base.SizeOfSides) * (AllSides - base.SizeOfSides));
            }
        }

         public override string ToString()
        {
            return string.Format(Name) + base.ToString();
        }
    }
}
