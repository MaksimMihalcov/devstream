using Vehicles.Abstractions;

namespace Vehicles.Models
{
    public class Car : MechanicalVehicle
    {
        public Car()
        {
            MaxSpeed = 420;
            Weight = 3000;
            Year = 1996;
            Model = "Car1";
        }
    }
}