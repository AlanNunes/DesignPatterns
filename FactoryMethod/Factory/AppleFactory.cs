using FactoryMethod.Product;
using System;

namespace FactoryMethod.Factory
{
    public class AppleFactory : SmartphoneFactory
    {
        public override ISmartphone Factory()
        {
            return new IPhone();
        }
    }
}
