﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder
    {
        private Vehicle Vehicle { get; }
        public VehicleBuilder()
        {
            Vehicle = new Vehicle();
        }


        public void SetWeels(int wheels)
        {
            Vehicle.Wheels = wheels;
        }
        public void SetDoors(int doors)
        {
            Vehicle.Doors = doors;
        }
        public void SetSeats(int seats)
        {
            Vehicle.Seats = seats;
        }
        public void SetEngine(int? power)
        {
            Vehicle.EnginePower = power;
        }
        public void SetTrunk(int capacity)
        {
            Vehicle.TrunkCapacity = capacity;
        }

        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
