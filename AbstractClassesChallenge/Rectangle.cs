using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // private int side;
        // private string name;
        public Rectangle(int sides, string name){
            // this.side = side;
            // this.name = name;
            NumSides = sides;
            Name = name;
        }

        // Implement your Rectangle class here.
        public override void SetArea(int NewArea){
            // Name = "Rectangle";
            // NumSides = 4
            area = NewArea;
            Console.log("This is for rectangle");
        }
    }
}
