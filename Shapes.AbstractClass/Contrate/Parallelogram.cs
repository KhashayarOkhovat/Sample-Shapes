using Shapes.AbstractClass.Enum;
namespace Shapes.AbstractClass
{
    public class Parallelogram : Rectangle
    {
        public double Height { get; set; }
        public override string Name => EnShapescs.Parallelogram.ToString();
        public Parallelogram(double _base,double width , double height):base(_base, width)
        {
            Height = height;
        }
        public override double Area()
        {
            return Height * Base;
        }
    }

}
