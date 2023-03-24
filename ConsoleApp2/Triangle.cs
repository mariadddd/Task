namespace ConsoleApp2
{
    internal class Triangle : Shape
    {
        #region Properties
        private double _side1;
        private double _side2;
        private double _side3;
        #endregion

        #region Constructors
        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            double half = Perimeter() / 2;
            double result = Math.Sqrt(half * (half - _side1) * (half - _side2) * (half - _side3));
            return result;
        }

        public override double Perimeter()
        {
            return _side1+_side2+_side3;
        }
        #endregion
    }
}
