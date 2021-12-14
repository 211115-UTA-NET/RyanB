using System;

namespace DynamicShapes
{
     class Circle : TwoDimensionalShape
    {
        // Implement your Square Class here.
        public Circle(double A) : base(A){
            this.Name = "Circle";
        }

        // public override double SetArea()
        // {
        //     this.Area = Math.PI * base.SizeOfSides;
        // }
        protected override double Area
        {
            get{
            return Math.PI * Math.Pow(base.SizeOfSides,2);
            }
        }

        public override string ToString()
        {
            return string.Format(Name) + base.ToString();
        }
    }
}
