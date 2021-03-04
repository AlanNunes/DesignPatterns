using Pizza.Interfaces;

namespace Pizza
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizzaType()
        {
            return base.GetPizzaType() + "\r\n with bacon";
        }
    }
}
