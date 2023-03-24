
namespace ConsoleApp2
{
    internal class Phonebook
    {
        List<Abonent> abonents = new List<Abonent>();
        #region Add abonent
        public void AddAbonent(Abonent abonent) 
        {
            abonents.Add(abonent); 
        }
        #endregion
        #region Delete abonent
        public void DeleteAbonent(int index)
        {
            if (index >= 0 && index < abonents.Count)
            abonents.RemoveAt(index);
        }
        #endregion
        #region Show abonent
        public string ShowAbonents()
        {
            int count = 1;
            string result = string.Empty;
            foreach (Abonent abonent in abonents)
            {
                result += count + abonent.GetInfo() + "\n";
                count++;
            }
            return result;
        }
        #endregion
        #region Find abonent
        public string FindAbonent(string name)
        {
            string result = string.Empty;
            foreach (Abonent abonent in abonents)
            {
                if (name == abonent.Name)
                    result = abonent.GetInfo();
                if (name != abonent.Name)
                    result = "Not found";
            }
            return result;
        }
        #endregion
    }
}
