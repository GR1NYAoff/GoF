using MediatorPattern.Interfaces;
using System.Collections.Generic;

namespace MediatorPattern.Logic
{
    internal class SpecificMediator : IMediator
    {
        private Dictionary<string, object> subscribers;

        public SpecificMediator()
        {
            subscribers = new Dictionary<string, object>();
        }

        public void Subscribe(string command, object handler)
        {
            subscribers[command] = handler;
        }

        public void Notify(string command)
        {
            Notify(null, command);
        }

        public void Notify(object sender, string command)
        {
            if (subscribers.ContainsKey(command))
            {
                (subscribers[command] as IHandler).DoWork();
            }
        }
    }
}
