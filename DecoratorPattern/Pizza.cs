using Pizza.Interfaces;

namespace Pizza
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "Normal Pizza";
        }
    }
}
