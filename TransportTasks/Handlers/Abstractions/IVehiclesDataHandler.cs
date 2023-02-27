using Vehicles.Abstractions;

namespace Handlers.Abstractions
{
    public interface IVehiclesDataHandler
    {
        public IEnumerable<IVehicle> SortTypesByAscending();
        public IEnumerable<IVehicle> FindTypes(string type);
    }
}