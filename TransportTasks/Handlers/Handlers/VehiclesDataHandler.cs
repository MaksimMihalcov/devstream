using Handlers.Abstractions;
using Vehicles.Abstractions;

namespace Handlers.Handlers
{
    public class VehiclesDataHandler : IVehiclesDataHandler
    {
        public IEnumerable<IVehicle> FindTypes(string type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVehicle> SortTypesByAscending()
        {
            throw new NotImplementedException();
        }
    }
}