using FactoryMethod.Enums;
using FactoryMethod.Product;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordering IPhone...");
            ISmartphone iphone = Shop.Order(ProductEnum.IPhone);
            iphone.Call();
            iphone.Ring();
            Console.WriteLine("Ordering Samsung M31...");
            ISmartphone samsungM31 = Shop.Order(ProductEnum.SamsungM31);
            samsungM31.Call();
            samsungM31.Ring();
        }
    }
}
