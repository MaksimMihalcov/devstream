using Providers.Abstractions;
using System.Collections;

namespace Providers.Providers.OutputProviders
{
    public class ConsoleOutputProvider : IOutputProvider
    {
        public void Write<T>(T obj)
        {
            if (typeof(T).GetInterface(nameof(IEnumerable)) != null)
            {
                foreach (var type in (IEnumerable)obj)
                {
                    Console.WriteLine(type);
                }
            }
            else
            {
                Console.WriteLine(obj);
            }
        }
    }
}
