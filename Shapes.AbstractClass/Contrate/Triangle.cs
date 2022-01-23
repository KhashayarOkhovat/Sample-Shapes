

using Shapes.AbstractClass.Enum;

namespace Shapes.AbstractClass
{
    public class Triangle : Shapes
    {
        public Triangle(double height, double _base)
        {
            Height = height;
            Base = _base;
        }
        public double Height { get; set; }
        public double Base { get; set; }
        
        public override double Area()
        {
            return Height * Base / 2;
        }
        public override string Name
        {
            get
            {
                return EnShapescs.Triangle.ToString();
            }
        }
        public override double Enviroment()
        {
            return Base * 3;
        }
    }
}
