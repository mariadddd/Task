namespace ConsoleApp2
{
    abstract class Storage
    {
        #region PrivateFields
        private protected string _name;
        private protected string _model;
        private protected double _capacity;
        #endregion

        #region Methods
        public abstract string GetMemoryAmount();
        public abstract void CopyingData(double data);
        public abstract double FreeMemoryAmount();
        public abstract string DeviceInfo();
        public abstract double UsedMemoryAmount();
        #endregion
    }
}
