using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class Client
    {
        public static void Execute()
        {

            var handler4 = new DiscountHandler(1000, 7500, "Kierownik sklepu");
            var handler3 = new DiscountHandler(500, 7500, handler4, "Kierownik sali");
            //var handler2 = new DiscountHandler(500, 10000, handler3, "Kierownik kas");
            var handler1 = new DiscountHandler(100, 10000, handler3, "Kasjer");



            var result = handler1.Discount(500, 15000);
            if (!result)
                Console.WriteLine("Nie otrzymaliśmy rabatu");

            result = handler3.Discount(500, 15000);
            if (!result)
                Console.WriteLine("Nie otrzymaliśmy rabatu");
        }
    }
}
