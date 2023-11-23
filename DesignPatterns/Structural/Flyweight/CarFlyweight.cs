using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Flyweight
{
    internal class CarFlyweight : ICloneable
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
