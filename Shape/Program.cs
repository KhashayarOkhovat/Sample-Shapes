using System;
using System.Collections.Generic;
using Shape.Contract;
using Shape.Concrat;
using Shape.Enum;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            
               
            Console.WriteLine("Circle : 1   Triangle : 2   Square : 3");
            Console.Write($"Type :");
            byte typeId = byte.Parse(Console.ReadLine());
            switch (typeId)
            {
                case 1:
                    Console.Write($"Radius :");
                    double rCircle = double.Parse(Console.ReadLine());
                    IShapes C = new Circle(rCircle);
                    Console.WriteLine($"Type:{C.Name}   " +$"Area : {C.Area()}   " +$"Enviromnt : {C.Enviroment()}");
                    break;
                case 2:
                    Console.Write($"Base :");
                    double bTriangle = double.Parse(Console.ReadLine());
                    Console.Write($"Height :");
                    double hTriangle = double.Parse(Console.ReadLine());
                    IShapes T = new Triangle(bTriangle, hTriangle);
                    Console.WriteLine($"Type:{T.Name}   " + $"Area : {T.Area()}   " + $"Enviromnt : {T.Enviroment()}");
                    break;
                case 3:
                    Console.Write($"Base :");
                    double bSquare = double.Parse(Console.ReadLine());
                    IShapes S = new Square(bSquare);
                    Console.WriteLine($"Type:{S.Name}   " + $"Area : {S.Area()}   " + $"Enviromnt : {S.Enviroment()}");
                    break;
            }
            if(typeId == Convert.ToByte(EnShapes.Circle))
            {

            }
            //var Shapes = new List<IShapes>();
            ////Shapes.Add(new Circle(rCircle));
            //Shapes.Add(new Triangle(5, 3));
            //Shapes.Add(new Square(5));
            //for (int i = 0; i < Shapes.Count; i++)
            //{
            //    Console.WriteLine($"Type:{Shapes[i].Name}   " +
            //        $"Area : {Shapes[i].Area()}   " +
            //        $"Enviromnt : {Shapes[i].Enviroment()}");

            
        }
    }
}
