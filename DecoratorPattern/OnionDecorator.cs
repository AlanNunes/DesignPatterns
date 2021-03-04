using Pizza.Interfaces;

namespace Pizza
{
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizzaType()
        {
            return base.GetPizzaType() + "\r\n with onion";
        }
    }
}
