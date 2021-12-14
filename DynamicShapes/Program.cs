using System;

namespace DynamicShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // double a, b, c;
            // Console.WriteLine("Hello World!");
            // Rectangle RectangleOne = new Rectangle();
            // RectangleOne.GetArea();
            Shape[] Shapes = new Shape[6];
            // Console.WriteLine("RECTANGLE: How Precise Is Your Length?");
            // double Length = double.Parse(Console.ReadLine());

            // Console.WriteLine("RECTANGLE: How Precise Is Your Width?");
            // double Width = double.Parse(Console.ReadLine());
            // // return (Length*Width);
            // double RecArea = (Length*Width);
            // Shapes[0] = new Rectangle();
            // Console.WriteLine("Triangle: How Precise Is Your Side A?");
            //  a = double.Parse(Console.ReadLine());

            // Console.WriteLine("Triangle: How Precise Is Your Side B?");
            // b = double.Parse(Console.ReadLine());

            // Console.WriteLine("Triangle: How Precise Is Your Side C?");
            // c = double.Parse(Console.ReadLine());

            // double AllSides = (a+b+c)/2;
            // // return Math.Sqrt(AllSides * (AllSides - a) *
            // // (AllSides - b) * (AllSides - c));
            // double TriArea = Math.Sqrt(AllSides * (AllSides - a) *
            // (AllSides - b) * (AllSides - c));
            // Shapes[1] = new Triangle();
            Shapes[0] = new Rectangle(10);
            Shapes[1] = new Triangle(10);
            Shapes[2] = new Circle(10);
            Shapes[3] = new Cube(10);
            Shapes[4] = new Square(10);
            Shapes[5] = new Sphere(10);

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
