using System;
using System.Collections.Generic;
using Shape.Contract;
using Shape.Concrat;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var Shapes = new List<IShapes>();
            Shapes.Add(new Circle(10));
            Shapes.Add(new Triangle(5,3));
            Shapes.Add(new Square(5));
            //Shapes[0].Area();
            //Shapes[0].Enviroment();
            //foreach (var item in Shapes)
            //   item.Area();
            //Console.WriteLine();
            //Console.WriteLine();
            for(int i=0; i < Shapes.Count; i++)
            {
                Console.WriteLine($"Type:{Shapes[i].Name}   " +
                    $"Area : {Shapes[i].Area()}   " +
                    $"Enviromnt : {Shapes[i].Enviroment()}");
                
            }
        }
    }
}
