using Notifier.Interfaces;
using System;

namespace Notifier
{
    public class SMSDecorator : NotifierDecorator
    {
        public SMSDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("SMS message sent");
        }
    }
}
