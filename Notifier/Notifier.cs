using Notifier.Interfaces;
using System;

namespace Notifier
{
    public class Notifier : INotifier
    {
        public virtual void Send()
        {
            Console.WriteLine("Message sent");
        }
    }
}
