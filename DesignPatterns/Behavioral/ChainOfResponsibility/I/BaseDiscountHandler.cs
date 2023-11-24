using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal abstract class BaseDiscountHandler : IDiscountHandler
    {
        protected float MaxDiscount { get; }
        protected float MinPrice { get; }
        IDiscountHandler Next { get; }

        public BaseDiscountHandler(float maxDiscount, float minPrice)
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }
        public BaseDiscountHandler(float maxDiscount, float minPrice, IDiscountHandler next) : this(maxDiscount, minPrice)
        {
            Next = next;
        }

        public virtual bool Discount(float value, float price)
        {
            return Next?.Discount(value, price) ?? false;
        }
    }
}
