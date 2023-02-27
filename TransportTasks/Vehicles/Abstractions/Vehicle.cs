using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Abstractions
{
    public abstract class Vehicle
    {
        public ushort Year { get; set; }
        public uint Weight { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"Year: {Year}, Weight: {Weight}, Model: {Model}";
        }
    }
}
