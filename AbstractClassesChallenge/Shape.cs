using System;

namespace AbstractClassesChallenge
{
    abstract public class Shape
    {
        public string Name { get; set; } = "";
        public double SizeOfSides { get; set; } = 0;
        protected double area;
        
        protected double Area 
        { 
            get
            {
                return this.area;
            } 
            set
            {
                if(value > 0)
                    this.area = value;
            }
        }
        
        // Constructor
           public Shape() : this(0)
        {
            this.Name = Name;
            this.Sides = Sides;
        }
          public Shape(double SizeOfSides)
        {
            this.Name = Name;
            this.Sides = Sides;
        }
        // public Shape(string Name, int NumSides) : this(Name, NumSides, 0){}
        // public Shape(string Name, int NumSides, double Area)
        // {
        //     this.Name = Name;
        //     this.NumSides = NumSides;
        // }

        // This method returns the general information about the shape.
        public void GetInfo()
        {
            System.Console.WriteLine($"This {Name} has {NumSides} sides and an area of {Area}");
        }

        // This method returns the area of the shape
        public double GetArea()
        {
            return this.Area;
        }
        
        // This method sets the Area of the shape
        public abstract double SetArea();
        public override abstract string ToString();

    }
}
