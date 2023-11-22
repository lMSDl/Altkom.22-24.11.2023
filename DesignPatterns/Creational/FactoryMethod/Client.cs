using Altkom._22_24._11._2023.DesignPatterns.Creational.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";

            elevator.Execute(action, 3);


             action = "GoTo";

            elevator.Execute(action, 9);


             action = "Down";

            elevator.Execute(action, 1);


             action = "Up";

            elevator.Execute(action, 2);
        }
    }
}
