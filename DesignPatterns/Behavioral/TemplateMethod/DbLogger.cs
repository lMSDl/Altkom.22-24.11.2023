using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DbLogger : Logger<DbLog, DbLogService>
    {
        protected override void Save(DbLog item, DbLogService? service)
        {
            service.Write(item);
        }

        protected override string PrepareMessage(string message)
        {
            return message;
        }

        protected override DbLog CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return new DbLog { DateTime = DateTime.Now, Message = message };
        }

        protected override DbLogService GetService()
        {
            return new DbLogService();
        }
    }
}
