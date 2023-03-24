namespace ConsoleApp2
{
    internal class CompoundShape : Shape
    {
        Shape[] _shapes;
        public CompoundShape(params Shape[] shapes)
        {
            _shapes = shapes;
        }

        public override double Area()
        {
            double result = 0;
            foreach (Shape shape in _shapes) 
            {
                result += shape.Area();
            }
            return result;
        }

        public override double Perimeter()
        {
            double result = 0;
            foreach (Shape shape in _shapes)
            {
                result += shape.Perimeter();
            }
            return result;
        }
    }
}
