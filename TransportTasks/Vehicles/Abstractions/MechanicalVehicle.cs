namespace Vehicles.Abstractions
{
    public abstract class MechanicalVehicle : Vehicle
    {
        public ushort MaxSpeed { get; set; }
        public override string ToString()
        {
            return $"Year: {Year}, Weight: {Weight}, Model: {Model}, MaxSpeed: {MaxSpeed}";
        }
    }
}