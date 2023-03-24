namespace ConsoleApp2
{
    internal class Square: Shape
    {
        #region Properties
        private double _side1;
        #endregion

        #region Constructors
        public Square(double side1)
        {
            _side1 = side1;
        }
        #endregion

        #region Methods
        public override double Area()
        {
             return _side1 * _side1;
        }

        public override double Perimeter()
        {
            return _side1*4;
        }
        #endregion
    }
}
