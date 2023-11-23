using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.Builder
{
    internal class BaseVehicleBuilder
    {
        protected Vehicle Vehicle { get; }
        public BaseVehicleBuilder()
        {
            Vehicle = new Vehicle();
        }

        public BaseVehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
