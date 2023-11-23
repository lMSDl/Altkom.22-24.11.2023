using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Adapter.I
{
    internal static class SquareToCircleConverter
    {
        public static Circle ToCircle(this Square square)
        {
            return new Circle() { R = square.A * Math.Sqrt(2) / 2 };
        }
    }
}
