using System;

namespace FactoryMethod.Product
{
    public class IPhone : ISmartphone
    {
        public void Call()
        {
            Console.WriteLine("Calling from IPhone...");
        }

        public void Ring()
        {
            Console.WriteLine("Ringing from IPhone...");
        }
    }
}
