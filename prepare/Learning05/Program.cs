using System;

class Program
{
    static void Main(string[] args)
    {
        /*
       Square cube=new Square( "green",5);
       Console.WriteLine( cube.GetColor());
       Console.WriteLine( cube.GetArea());

       Circle sphere=new Circle( "yellow",3);
       Console.WriteLine( sphere.GetColor());
       Console.WriteLine( sphere.GetArea());

       Rectangle rectangle=new Rectangle( "blue",3,5);
       Console.WriteLine( rectangle.GetColor());
       Console.WriteLine( rectangle.GetArea());
        */

       List<Shape> shapes= new List<Shape>();
       shapes.Add(new Square("green",5));
       shapes.Add(new Circle( "yellow",3));
       shapes.Add(new Rectangle( "blue",3,5));

       foreach(Shape shape in shapes )
       {
            Console.WriteLine($"the color is { shape.GetColor()}");
            Console.WriteLine( $"the area of the shape is {shape.GetArea()}");

       }

       

    
    }
}