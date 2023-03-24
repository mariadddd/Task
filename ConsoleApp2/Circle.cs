namespace ConsoleApp2
{
    internal class Circle: Shape
    {
        #region Properties
        private double _radius;
        #endregion

        #region Constructors
        public Circle (double radius)
        {
            _radius = radius;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
        #endregion
    }
}
