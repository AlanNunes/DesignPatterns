using Pizza.Interfaces;

namespace Pizza
{
    public class PizzaDecorator : IPizza
    {
        private IPizza Pizza { get; set; }
        public PizzaDecorator(IPizza pizza)
        {
            this.Pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return this.Pizza.GetPizzaType();
        }
    }
}
