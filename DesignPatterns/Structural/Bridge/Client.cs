﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Bridge
{
    internal class Client
    {
        public static void Execute()
        {
            Shape shape = new Square();
            Console.WriteLine(shape);
            Color color = new Red();
            Console.WriteLine(color);

            shape.Color = color;
            Console.WriteLine(shape);
        }
        }
}
