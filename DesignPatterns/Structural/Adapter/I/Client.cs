using Altkom._22_24._11._2023.SOLID.O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            ICircle circle = new Circle() { R = 5 };
            //Square square = new Square() { A = 5 };
            //CheckR(square);

            CheckR(circle);

            ICircle squareCircle = new SquareToCircleAdapter(new Square() { A = 8 });
            CheckR(squareCircle);
        }

        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }
    }
}
