namespace Providers.Abstractions
{
    public interface IOutputProvider
    {
        public void Write<T>(T obj);
    }
}
