using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Facade.III
{
    internal interface  IByteArrayConverter
    {
        byte[] ToByteArray<T>(T obj);
    }
}
