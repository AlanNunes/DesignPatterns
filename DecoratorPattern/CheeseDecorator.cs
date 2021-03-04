using Pizza.Interfaces;

namespace Pizza
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizzaType()
        {
            return base.GetPizzaType() + "\r\n with cheese";
        }
    }
}
