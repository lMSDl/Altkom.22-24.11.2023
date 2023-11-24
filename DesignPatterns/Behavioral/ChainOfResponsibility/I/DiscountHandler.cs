using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : BaseDiscountHandler
    {
        private string Name { get; }

        public DiscountHandler(float maxDiscount, float minPrice, string name) : this(maxDiscount, minPrice, null, name)
        {
        }

        public DiscountHandler(float maxDiscount, float minPrice, IDiscountHandler next, string name) : base(maxDiscount, minPrice, next)
        {
            Name = name;
        }

        public override bool Discount(float value, float price)
        {
            if (value > MaxDiscount || price < MinPrice)
                return base.Discount(value, price);

            Console.WriteLine($"{Name} udzielił rabatu {value}");
            return true;
        }
    }
}
