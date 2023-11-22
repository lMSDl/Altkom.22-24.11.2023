using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public void Execute(IElevatorOperation operation, int floor)
        {
            operation?.Operate(floor);
        }

        public void Execute(string operation, int floor)
        {
            if (!_operations.TryGetValue(operation, out var elevatorOperation))
            {
                switch (nameof(Elevator) + operation)
                {
                    case nameof(ElevatorDown):
                        elevatorOperation = new ElevatorDown();
                        break;
                    case nameof(ElevatorUp):
                        elevatorOperation = new ElevatorUp();
                        break;
                    case nameof(ElevatorGoTo):
                        elevatorOperation = new ElevatorGoTo();
                        break;
                    default:
                        return;
                }
                _operations[operation] = elevatorOperation;
            }

            Execute(elevatorOperation, floor);
        }
    }
}
