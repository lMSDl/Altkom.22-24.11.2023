using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.SOLID
{
    public interface IMessage
    {
        void SendMessage();
    }
    class SMS : IMessage
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
        public void SendMessage()
        {
            SendMMS();
        }

    }

    class Mail : IMessage
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
        public void SendMessage()
        {
            SendMail();
        }
    }

    class Messenger
    {
        public IEnumerable<IMessage> Messages { get; set; }

        public Messenger(IEnumerable<IMessage> messages)
        {
            Messages = messages;
        }


        public void SendMessages(IEnumerable<IMessage> messages)
        {
            Messages = messages;
            SendMessages();
        }

        public void SendMessages()
        {
            foreach (var message in Messages)
            {
                message.SendMessage();
            }
        }
    }
}
