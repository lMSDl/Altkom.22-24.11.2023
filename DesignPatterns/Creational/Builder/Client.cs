using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);

            Console.WriteLine(vehicle);


            var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder.SetWeels(4);
            vehicleBuilder.SetSeats(5);
            vehicleBuilder.SetDoors(4);
            vehicleBuilder.SetEngine(100);
            vehicleBuilder.SetTrunk(500);
            vehicle = vehicleBuilder.Build();

            Console.WriteLine(vehicle);

            vehicle = new Vehicle() { Doors = 4, TrunkCapacity = 500, EnginePower = 100, Seats = 4, Wheels = 4 };

            Console.WriteLine(vehicle);
        }
    }
}
