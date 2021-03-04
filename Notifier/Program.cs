using Notifier.Interfaces;
using System;

namespace Notifier
{
    class Program
    {
        static void Main(string[] args)
        {
            INotifier notifier = new Notifier();
            INotifier slackDecorator = new SlackDecorator(notifier);
            INotifier facebookDecorator = new FacebookDecorator(slackDecorator);
            INotifier SMSDecorator = new SMSDecorator(facebookDecorator);

            SMSDecorator.Send();
        }
    }
}
