using System;
using System.Collections.Generic;
namespace Shapes.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> shapes = new List<Shapes>();
            shapes.Add(new Triangle(3, 5));
            shapes.Add(new Square(5));
            shapes.Add(new Circle(3));
            shapes.Add(new Rectangle(2, 5));
            shapes.Add(new Parallelogram(3, 4, 5));

            foreach (var item in shapes)
            {
                Console.WriteLine($"type is : {item.Name} Area : {item.Area()} Enviroment : {item.Enviroment()}");
                
            }
        }
        
        
    }
}
