using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("blue", 5);
        Circle myCircle = new Circle("Red", 5);
        Rectangle myRectangle = new Rectangle("Orange", 5, 6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(myCircle);
        shapes.Add(myRectangle);
        shapes.Add(mySquare);

        foreach (Shape shape in shapes)
        {
            GetShapeInfo(shape);
        }

        // Test code
        // Square mySquare = new Square("blue", 5);
        // Console.WriteLine(mySquare.GetArea());
        // Console.WriteLine(mySquare.GetColor());

        // Rectangle myRectangle = new Rectangle("Red", 5, 6);
        // Console.WriteLine(myRectangle.GetArea());
        // Console.WriteLine(myRectangle.GetColor());

        // Circle myCircle = new Circle("Red",5);
        // Console.WriteLine(myCircle.GetArea());
        // Console.WriteLine(myCircle.GetColor());
    }
    static void GetShapeInfo(Shape shape)
    {
        Console.WriteLine("\n---------------------------------------------------------------------\n");
        Console.WriteLine($"Area: {shape.GetArea()}");
        Console.WriteLine($"color: {shape.GetColor()}");
        Console.WriteLine("\n---------------------------------------------------------------------");
    }
}