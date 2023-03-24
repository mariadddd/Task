
namespace ConsoleApp2
{
    internal class Abonent
    {
        #region Properties
        public string Name { get; set; }
        public string Notes { get; set; }
        public int Number { get; set; }
        #endregion

        #region Constructors
        public Abonent(string name, string notes, int number)
        {
            Name = name;
            Notes = notes;
            Number = number;
        }
        #endregion

        #region Methods
        public string GetInfo() => $" _name: {Name}\t Notes: {Notes}\t Number: {Number}\n";
        #endregion
    }
}
