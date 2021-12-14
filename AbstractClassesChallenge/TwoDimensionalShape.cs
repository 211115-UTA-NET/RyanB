using System;

namespace AbstractClassesChallenge
{
    abstract class TwoDimensionalShape : Shape
    {
        
        // Constructor
         public TwoDimensionalShape(double A) : base(A){

         }
        public override double SetArea(){
            this.Area = Area;
        }

        public override string ToString(){
            return string.Format(" Is A 2D Shape");
        }
        
    }
}
