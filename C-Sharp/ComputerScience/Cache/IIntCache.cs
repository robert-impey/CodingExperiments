namespace Cache
{
    public interface IIntCache
    {
        int Capacity { get; }
        int Get(int key);
        void Put(int key, int value);
    }
}