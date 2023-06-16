using System;

class Program
{
    static void Main(string[] args)
    {
        List <Shape> shapes = new List<Shape>();
        Square square = new Square("red",5);
        Rectangle rectangle = new Rectangle("red",5,6);
        Circle circle = new Circle("red",5);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        
        for(int i=0;i<shapes.Count;i++){
            Console.WriteLine(shapes[i].GetArea());
            Console.WriteLine(shapes[i].GetColor());
        }
        Console.Read();
    }
}