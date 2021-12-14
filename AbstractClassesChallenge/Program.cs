using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Rectangle RectangleOne = new Rectangle();
            // RectangleOne.GetArea();
            Shape[] Shapes = new Shape[6];
            Shapes[0] = new Circle(10);
            Shapes[1] = new Cube(10);
            Shapes[2] = new Rectangle();
            Shapes[3] = new Sphere(10);
            Shapes[4] = new Square(10);
            Shapes[5] = new Triangle();

            foreach (Shape Element in Shapes)
            {
                if(Element is TwoDimensionalShape){
                    Console.WriteLine(Element);
                    Element.GetInfo();
                    Element.GetArea();
                } else if(Element is ThreeDimensionalShape){
                    ThreeDimensionalShape ThreeDShape = (ThreeDimensionalShape)Element;
                    /*^^ casting the volume property here because i want to keep the 
                    array of Shapes broad.
                    */
                    Console.WriteLine(Element);
                    
                    Element.GetInfo();
                    Element.GetArea();
                    Console.WriteLine("The Volume is {0:N}\n", ThreeDShape.Volume);
                    /*^^ casting the volume property here because i want to keep the 
                    array of Shapes broad.
                    */
                }
            }
    // Console.ReadKey();
        }
    }
}
