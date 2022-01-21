using Shape.Contract;
using Shape.Enum;

namespace Shape.Concrat
{
    public class Square : IShapes
    {
        public Square(double _base)
        {
            Base = _base;
        }
        public string Name
        {
            get
            {
                return EnShapes.Square.ToString();
            }

        }
        public double Base { get; set; }

        double IShapes.Area()

        {
            var a = Base * Base;
            return a;
        }

        double IShapes.Enviroment()
        {
            var e = 4 * Base;
            return e;
        }
    }
}
