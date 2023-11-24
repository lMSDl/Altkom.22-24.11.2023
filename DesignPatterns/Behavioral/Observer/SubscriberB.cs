using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Observer
{
    internal class SubscriberB : Subscriber
    {
        public override void OnNext(int value)
        {
            if (value % 2 == 0)
                Console.WriteLine("SubscriberB zareagował");
        }
    }
}
