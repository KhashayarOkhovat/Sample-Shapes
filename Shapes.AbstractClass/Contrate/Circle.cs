
using Shapes.AbstractClass.Enum;
namespace Shapes.AbstractClass
{
    public class Circle : Shapes
    {
        public Circle(double _radius)
        {
            Radius = _radius;
        }
        public double Radius { get; set; }
        public override string Name
        {
            get
            {
                return EnShapescs.Circle.ToString();
            }
        }

        

        double p = 3.14;

        public override double Area()
        {
            return p * Radius * Radius;
        }

        public override double Enviroment()
        {
            return 2 * Radius * p;

        }
    }
}
