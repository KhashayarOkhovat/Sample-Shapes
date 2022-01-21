using Shape.Contract;
using Shape.Enum;

namespace Shape.Concrat
{
    public class Circle : IShapes
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public string Name
        {
            get
            {
                return EnShapes.Circle.ToString();
            }

        }
        public double Radius { get; set; }
        private double p  = 3.14;
        double IShapes.Area()

        {
            var a = Radius * Radius * p;
            return a;
        }

        double IShapes.Enviroment()
        {
            var e = 2 * Radius * p;
            return e;
        }
    }
}
