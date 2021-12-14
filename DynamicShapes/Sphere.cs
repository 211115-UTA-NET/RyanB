using System;

namespace DynamicShapes
{
     class Sphere : ThreeDimensionalShape
    {
        // Implement your Square Class here.
        public Sphere(double A) : base(A){
            this.Name = "Sphere";
        }

        // public override double SetArea()
        // {
        //     this.Area = Math.PI * 4 * Math.Pow(base.SizeOfSides,2);
        // }
        protected override double Area
        {
            get{
             return Math.PI * 4 * Math.Pow(base.SizeOfSides,2);
            }
        }

        public override double Volume{
            get{
                return (4 * Math.PI * Math.Pow(base.SizeOfSides, 3))/3;
            }
        }

        public override string ToString()
        {
            return string.Format(Name) + base.ToString();
        }
    }
}
