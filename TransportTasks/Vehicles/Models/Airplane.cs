using Vehicles.Abstractions;

namespace Vehicles.Models
{
    public class Airplane : Vehicle
    {
        public Airplane()
        {
            Weight = 3120;
            Year = 1994;
            Model = "Airplane1";
        }
    }
}