using System;

namespace AbstractClassesChallenge
{
     class Triangle : TwoDimensionalShape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
            double a, b, c;
            public Triangle(){
                // this.NumSides = sides;
                // this.Name = name;
            }

        public override double SetArea()
        {
           Console.WriteLine("Triangle: How Precise Is Your Side A?");
             a = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangle: How Precise Is Your Side B?");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangle: How Precise Is Your Side C?");
            c = double.Parse(Console.ReadLine());

            double AllSides = (a+b+c)/2;
            this.Area = Math.Sqrt(AllSides * (AllSides - a) *
            (AllSides - b) * (AllSides - c));
        }

         public override string ToString()
        {
            return string.Format("Triangle") + base.ToString();
        }
    }
}
