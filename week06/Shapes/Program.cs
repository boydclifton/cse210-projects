using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        Square square1 = new Square("red", 21);
        Rectangle rectangle1 = new Rectangle("green", 23, 4);
        Circle circle1 = new Circle("yellow", 13);
        _shapes.Add(square1);
        _shapes.Add(rectangle1);
        _shapes.Add(circle1);
        
        

        foreach (Shape shape in _shapes)
        {

            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The {color} shape will have an area of: {area}");

        }

        



    }

  


}

