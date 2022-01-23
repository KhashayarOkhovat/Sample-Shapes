

using Shapes.AbstractClass.Enum;

namespace Shapes.AbstractClass
{
    public class Square : Shapes
    {
        public Square(double _base)
        {
            Base = _base;
        }
        public double Base { get; set; }
        public override double Area()
        {
            return Base * Base;
        }
        public override string Name
        {
            get
            {
                return EnShapescs.Square.ToString();
            }
        }
        public override double Enviroment()
        {
            return Base * 4;
        }
    }
}
