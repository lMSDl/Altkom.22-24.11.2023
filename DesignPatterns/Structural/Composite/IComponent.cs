using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Composite
{
    internal interface IComponent
    {
        string Name { get; }
        float GetValue();
    }
}
