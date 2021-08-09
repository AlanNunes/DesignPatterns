using System;

namespace FactoryMethod.Product
{
    public class SamsungM31 : ISmartphone
    {
        public void Call()
        {
            Console.WriteLine("Calling from Samsung M31...");
        }

        public void Ring()
        {
            Console.WriteLine("Ringing from Samsung M31...");
        }
    }
}
