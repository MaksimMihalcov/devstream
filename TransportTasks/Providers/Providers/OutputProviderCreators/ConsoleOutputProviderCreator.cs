using Providers.Abstractions;
using Providers.Providers.OutputProviders;

namespace Providers.Providers.OutputProviderCreators
{
    public class ConsoleOutputProviderCreator : IOutputProviderCreator
    {
        public IOutputProvider CreateOutputProvider()
        {
            return new ConsoleOutputProvider();
        }
    }
}
