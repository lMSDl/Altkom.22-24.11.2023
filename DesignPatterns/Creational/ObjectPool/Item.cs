using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.ObjectPool
{
    public class Item
    {
        public Item()
        {
        }

        public bool IsVisible { get; set; }

        public byte[] Content { get; } = new byte[10240];

    }
}
