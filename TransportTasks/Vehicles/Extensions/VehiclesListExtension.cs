using Vehicles.Abstractions;

namespace Vehicles.Extensions
{
    public static class VehiclesListExtension
    {
        public static IEnumerable<Vehicle> FindTypes(this IEnumerable<Vehicle> vehicles, string value)
        {
            return vehicles.Where(x => x.GetType().Name.Contains(value));
        }

        public static IEnumerable<Vehicle> SortTypesByAscending(this IEnumerable<Vehicle> vehicles)
        {
            return vehicles.OrderBy(x => x.GetType().Name).ToList();
        }
    }
}