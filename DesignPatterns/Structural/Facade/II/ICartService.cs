using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Facade.II
{
    internal interface ICartService
    {
        void AddProduct(int productId, float price);
        float GetValute();
        int GetId();
    }
}
