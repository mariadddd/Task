namespace ConsoleApp2
{
    internal class Flash : Storage
    {
        #region PrivateFields
        double _speedUSB3;
        double _freeMemory;
        double _usedMemory;
        #endregion

        #region Constructors
        public Flash(string name, string model, double speedUSB3, double capacity)
        {
            _name = name;
            _model = model;
            _speedUSB3 = speedUSB3;
            _capacity = capacity;
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
            string result = $"Name:{_name}\nModel:{_model}\nCapacity:{_capacity}" +
                $"\nFree memory:{_freeMemory}\nUsed memory:{_usedMemory}\nUSB speed:{_speedUSB3} \n";
            return result;
        }
        public override double FreeMemoryAmount()
        {
            double result = _freeMemory;
            return result;
        }
        public override string GetMemoryAmount()
        {
            string result = $"Capasity:{_capacity}\nFree memory:{_freeMemory}\nUsed memory:{_usedMemory} \n";
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
