using Vehicles.Abstractions;

namespace Vehicles.Models
{
    public class Plane : MechanicalVehicle
    {
        public Plane()
        {
            Weight = 200000;
            MaxSpeed = 930;
            Year = 2001;
            Model = "Plane1";
        }
    }
}