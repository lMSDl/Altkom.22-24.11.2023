using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Composite
{
    internal abstract class Composite : IComponent
    {
        public string Name => GetType().Name;
        public IList<IComponent> Components { get; set; } = new List<IComponent>();

        public float GetValue()
        {
            var value = Components.Sum(x => x.GetValue());
            Console.WriteLine($"Wartość {Name} to {value}");
            return value;
        }
    }
}
