using System;

namespace AbstractClassesChallenge
{
     class Circle : TwoDimensionalShape
    {
        // Implement your Square Class here.
        public Circle(double A) : base(A){

        }

        public override double SetArea()
        {
            this.Area = Math.PI * base.SizeOfSides;
        }

        public override string ToString()
        {
            return string.Format("Circle") + base.ToString();
        }
    }
}
