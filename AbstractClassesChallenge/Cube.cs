using System;

namespace AbstractClassesChallenge
{
     class Cube : ThreeDimensionalShape
    {
        // Implement your Square Class here.
        public Cube(double A) : base(A){

        }

        public override double SetArea()
        {
            this.Area = 6 * Math.Pow(base.SizeOfSides,2);
        }

            public override double Volume{
            get{
                return Math.Pow(base.SizeOfSides, 3);
            }
        }

        public override string ToString()
        {
            return string.Format("Cube") + base.ToString();
        }
    }
}
