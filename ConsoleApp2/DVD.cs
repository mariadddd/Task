namespace ConsoleApp2
{
    internal class DVD : Storage
    {
        #region PrivateFields
        double _speed;
        int _sides;
        double _freeMemory;
        double _usedMemory;
        #endregion

        #region Constructors
        public DVD(string name, string model, double speed, int sides)
        {
            _name = name;
            _model = model;
            _speed = speed;
            _sides = sides;
            if (_sides == 1) _capacity = 4700;
            if (_sides == 2) _capacity = 9000;
            _freeMemory = _capacity;
        }
        #endregion

        #region Methods
        public override void CopyingData(double data)
        {
            if (_freeMemory >= data)
            {
                _freeMemory -= data;
                _usedMemory += data;
            }
        }
        public override string DeviceInfo()
        {
            string result = $"Name:{_name}\nModel:{_model}\nCapacity:{_capacity}\nFree memory:{_freeMemory}" +
                $"\nUsed memory:{_usedMemory}\nUSB speed:{_speed}\nType:{_sides}  \n";
            return result;
        }
        public override double FreeMemoryAmount()
        {
            double result = _freeMemory;
            return result;
        }
        public override string GetMemoryAmount()
        {
            string result = $"Capasity:{_capacity}\nFree memory:{_freeMemory}\nUsed memory:{_usedMemory}  \n";
            return result;
        }
        public override double UsedMemoryAmount()
        {
            double result = _usedMemory;
            return result;
        }
        #endregion
    }
}
