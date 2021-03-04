using Notifier.Interfaces;
using System;

namespace Notifier
{
    public class FacebookDecorator : NotifierDecorator
    {
        public FacebookDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("Facebook message sent");
        }
    }
}
