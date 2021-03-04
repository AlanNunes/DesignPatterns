using Notifier.Interfaces;
using System;

namespace Notifier
{
    public class SlackDecorator : NotifierDecorator
    {
        public SlackDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("Slack message sent");
        }
    }
}
