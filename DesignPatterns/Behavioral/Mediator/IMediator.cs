using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Mediator
{
    internal interface IMediator
    {
        void Join(ChatMemeber member);
        void Quit(ChatMemeber member);
        void Send(string from, string message);
        void Send(string from, string to, string message);
    }
}
