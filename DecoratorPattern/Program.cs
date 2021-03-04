using Pizza.Interfaces;
using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza cheeseDecorator = new CheeseDecorator(pizza);
            IPizza baconDecorator = new BaconDecorator(cheeseDecorator);
            IPizza onionDecorator = new OnionDecorator(baconDecorator);

            Console.WriteLine(onionDecorator.GetPizzaType());
        }
    }
}
