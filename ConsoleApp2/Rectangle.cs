namespace ConsoleApp2
{
    internal class Rectangle: Shape
    {
        #region Properties
        double _side1;
        double _side2;
        #endregion

        #region Constructors
        public Rectangle(double side1, double side2 )
        {
            _side1 = side1;
            _side2 = side2;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return _side1 * _side2;
        }
        public override double Perimeter()
        {
            return (_side1 + _side2) * 2;
        }
        #endregion
    }
}
