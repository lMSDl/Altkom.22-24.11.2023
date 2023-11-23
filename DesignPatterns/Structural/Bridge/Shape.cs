using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Bridge
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public override string ToString()
        {
            return (Color?.ToString() ?? "") + GetType().Name;
        }
    }
}
