using System;

namespace AbstractClassesChallenge
{
     class Square : TwoDimensionalShape
    {
        // Implement your Square Class here.
        public Square(double A) : base(A){

        }

        public override double SetArea()
        {
            this.Area = Math.Pow(base.SizeOfSides,2);
        }

        public override string ToString()
        {
            return string.Format("Square") + base.ToString();
        }
    }
}
