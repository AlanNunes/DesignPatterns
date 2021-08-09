using FactoryMethod.Product;
using System;

namespace FactoryMethod.Factory
{
    public class SamsungFactory : SmartphoneFactory
    {
        public override ISmartphone Factory()
        {
            return new SamsungM31();
        }
    }
}
