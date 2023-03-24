namespace ConsoleApp2
{
    internal class HDD : Storage
    {
        #region PrivateFields
        double _speedUSB2;
        double _quantityOfParts;
        double _volumeOfParts;
        double _freeMemory;
        double _usedMemory;

        #endregion

        #region Constructors
        public HDD(string name, string model, double speedUSB2, double quantityOfParts, double amountOfParts)
        {
            _name = name;
            _model = model;
            _speedUSB2 = speedUSB2;
            _quantityOfParts = quantityOfParts;
            _volumeOfParts = amountOfParts;
            _capacity = _quantityOfParts * _volumeOfParts;
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
            // event calling if memory is not enough 
        }

        public override string DeviceInfo()
        {
            string result = $"Name:{_name}\nModel:{_model}\nCapacity:{_capacity}\nFree memory:{_freeMemory}\nUsed memory:{_usedMemory}" +
                $"\nUSB 2 speed:{_speedUSB2}\nQuanty of parts:{_quantityOfParts}\nVolume of parts:{_volumeOfParts}\n";
            return result;
        }

        public override double FreeMemoryAmount()
        {
            double result = _freeMemory;
            return result;
        }

        public override string GetMemoryAmount()
        {
            string result = $"Capasity:{_capacity}\nFree memory:{_freeMemory}\nUsed memory:{_usedMemory}\n";
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
