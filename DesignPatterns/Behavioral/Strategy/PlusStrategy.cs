using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Strategy
{
    internal class PlusStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a + b;
        }
    }
}
