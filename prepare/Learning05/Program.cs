using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square area1 = new Square("Blue", 10);
        shapes.Add(area1);

        Rectangle area2 = new Rectangle("Green", 3, 6);
        shapes.Add(area2);

        Circle area3 = new Circle("Black", 2);
        shapes.Add(area3);
        
        foreach (Shape  s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}