using Shape.Contract;
using Shape.Enum;

namespace Shape.Concrat
{
    public class Triangle : IShapes
    {
        public Triangle(double hight, double _base)
        {
            Hight = hight;
            Base = _base;
        }
        
        public double Hight { get; set; }
        public double Base { get; set; }
        public string Name
        {
            get
            {
                return EnShapes.Traiangle.ToString();
            }

        }
        double IShapes.Area()
        {
            var a = Hight * Base / 2;
            return a;
        }

        double IShapes.Enviroment()
        {
            var e = 3 * Base;
            return e;
        }
    }
}
