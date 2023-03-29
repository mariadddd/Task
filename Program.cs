namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] ints = { 1, 2, 8, 4 };
            string[] strings = { "hhh", "jjjjjjjj", "k" };
            MinMax<int> minMax = new(ints);
            MinMax<string> minMax2 = new(strings);
            Console.WriteLine(minMax.Min());
            Console.WriteLine(minMax.Max());
            Console.WriteLine(minMax2.Min());
            Console.WriteLine(minMax2.Max());
        }
    }
}