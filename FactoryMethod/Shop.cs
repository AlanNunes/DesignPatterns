using FactoryMethod.Enums;
using FactoryMethod.Factory;
using FactoryMethod.Product;
using System;

namespace FactoryMethod
{
    public static class Shop
    {
        public static ISmartphone Order(ProductEnum product)
        {
            if (ProductEnum.IPhone == product)
            {
                return new AppleFactory().Factory();
            }
            else if (ProductEnum.SamsungM31 == product)
            {
                return new SamsungFactory().Factory();
            }
            throw new Exception();
        }
    }
}
