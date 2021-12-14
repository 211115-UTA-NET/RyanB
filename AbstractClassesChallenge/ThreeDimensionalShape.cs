using System;

namespace AbstractClassesChallenge
{
    abstract class ThreeDimensionalShape : Shape
    {
        
        // Constructor
         public ThreeDimensionalShape(double A) : base(A){

         }
        public override double SetArea(){
            this.Area = Area;
        }
        public abstract double Volume { get;}

        public override string ToString(){
            return string.Format(" Is A 3D Shape");
        }
        
    }
}
