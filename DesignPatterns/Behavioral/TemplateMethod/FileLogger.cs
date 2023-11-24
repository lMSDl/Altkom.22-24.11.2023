using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger : Logger<string, FileService>
    {
        protected override string PrepareMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return message;
        }

        protected override void Save(string item, FileService? service)
        {
            service.Write(item);
        }

        protected override string CreateItem(string message)
        {
            return message;
        }

        protected override FileService GetService()
        {
            return new FileService();
        }
    }
}
