using Vehicles.Abstractions;

namespace Vehicles.Models
{
    public class Bicycle : Vehicle
    {
        public Bicycle()
        {
            Weight = 50;
            Year = 2001;
            Model = "Bicycle1";
        }
    }
}