﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Altkom._22_24._11._2023.DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.AbstractFactory
{
    internal class Client
    {
        public static void Execute()
        {
            Order order;

            order = new Order(new HondaFactory(), nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(new ToyotaFactory(), nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(new ToyotaFactory(), nameof(ISuv), "full");
            Console.WriteLine(order.ManufacturedCarName());
        }
    }
}
