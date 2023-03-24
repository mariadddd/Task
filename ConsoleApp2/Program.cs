namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            HDD hdd = new("name", "model", 300, 5, 12);
            Flash flash = new("name", "model", 400, 74);
            DVD dvd = new("name", "model", 5, 2);
            Console.WriteLine(hdd.GetMemoryAmount());
            Console.WriteLine(flash.DeviceInfo());
            Console.WriteLine(dvd.GetMemoryAmount());
            hdd.CopyingData(55);
            flash.CopyingData(67890);
            dvd.CopyingData(6700);
            Console.WriteLine(hdd.DeviceInfo());
            Console.WriteLine(flash.DeviceInfo());
            Console.WriteLine(dvd.DeviceInfo());
        }
    }
}
