using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Facade.II
{
    internal class Client
    {
        public static void Execute()
        {
            var shop = new Facade();


            int[] productIds = new[] { 2, 63, 21, 7 };
            shop.Buy(productIds);
            
        }
    }
}
