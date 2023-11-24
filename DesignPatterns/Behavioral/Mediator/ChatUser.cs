using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Mediator
{
    internal class ChatUser : ChatMemeber
    {
        public override void Receive(string from, string message, bool isPrivate)
        {
            Console.WriteLine($"{from}{(isPrivate ? $" to {Nick}" : "")}: {message}");
        }
    }
}
