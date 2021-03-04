using Notifier.Interfaces;

namespace Notifier
{
    public class NotifierDecorator : INotifier
    {
        private INotifier Notifier { get; set; }
        public NotifierDecorator(INotifier notifier)
        {
            this.Notifier = notifier;
        }
        public virtual void Send()
        {
            this.Notifier.Send();
        }
    }
}
