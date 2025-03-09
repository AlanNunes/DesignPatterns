using AbstractFacotryPattern.Products;

namespace AbstractFacotryPattern.ConcreteProducts
{
    internal class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("You sat on Victorian chair.");
        }
    }
}