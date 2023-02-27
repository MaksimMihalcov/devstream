using Providers.Abstractions;
using Providers.Providers.OutputProviders;

namespace Providers.Providers.OutputProviderCreators
{
    public class DiskOutputProviderCreator : IOutputProviderCreator
    {
        public IOutputProvider CreateOutputProvider()
        {
            return new DiskOutputProvider();
        }
    }
}
