using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Mediator
{
    internal abstract class ChatMemeber
    {
        private IMediator mediator;
        public string Nick { get; set; }
        public IMediator Mediator
        {
            get => mediator;
            set
            {
                if (mediator != null)
                    mediator.Quit(this);
                mediator = value;
                if (mediator != null)
                    mediator.Join(this);
            }
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}
