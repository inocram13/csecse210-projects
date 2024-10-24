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

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine();

        }

    }
}