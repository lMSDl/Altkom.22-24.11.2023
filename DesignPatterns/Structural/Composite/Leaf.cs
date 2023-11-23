using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Composite
{
    public abstract class Leaf : IComponent
    {
        public string Name => GetType().Name;
        public float Price { get; set; }

        protected Leaf(float price)
        {
            Price = price;
        }

        public float GetValue()
        {
            Console.WriteLine($"Wartość {Name} to {Price}");
            return Price;
        }
    }
}
