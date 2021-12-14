using System;

namespace DynamicShapes
{
    abstract class ThreeDimensionalShape : Shape
    {
        
        // Constructor
         public ThreeDimensionalShape(double A) : base(A){

         }
        // public override double SetArea(){
        //     this.Area = Area;
        // }
        protected override abstract double Area{
            // this.Area = Area;
            get;
        }
        public abstract double Volume { get;}

        public override string ToString(){
            return string.Format(" Is A 3D Shape");
        }
        
    }
}
