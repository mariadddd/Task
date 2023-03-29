namespace MinMax
{
    internal class MinMax<T>
    {
        T[] _data;
        public MinMax(T[] data) {_data = data;}
        public T Min() => _data.Min();
        public T Max() => _data.Max();
    }
}
