using System;
using shape_demo;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(4, "Red")); 
        shapes.Add(new Rectangle(3, 5, "Blue"));
        shapes.Add(new Circle(2, "Green")); 

        

        Square s1 = new Square(4, "pink");

        Console.WriteLine("Area of the square: " + s1.GetArea());
        Console.WriteLine("Color of the square: " + s1.GetColor());

        Rectangle r1 = new Rectangle(12,12,"Yellow green");

        Console.WriteLine("Area of Rectangle: " + r1.GetArea());
        Console.WriteLine("Color of Rectangle: " + r1.GetColor());

        Circle c1 = new Circle(13, "Grey");
         Console.WriteLine("Area of Circle: " + c1.GetArea());
        Console.WriteLine("Color of Circle: " + c1.GetColor());


    }
}