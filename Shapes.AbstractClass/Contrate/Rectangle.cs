using Shapes.AbstractClass.Enum;
namespace Shapes.AbstractClass
{
    public class Rectangle : Square
    {
        public double Wight { get; set; }
        public Rectangle(double _base,double wight) : base(_base)
        {
            Wight = wight;
        }
        public override double Area()
        {
            return Wight * Base;
        }
        public override double Enviroment()
        {
            return 2*(Wight + Base);
        }
        public override string Name => EnShapescs.Rectangle.ToString();
    }

}
