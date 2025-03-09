using AbstractFacotryPattern.Products;

namespace AbstractFacotryPattern.ConcreteProducts
{
    internal class VictorianSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("You layed on Victorian Sofa.");
        }

        public void SitOn()
        {
            Console.WriteLine("You sat on Victorian Sofa");
        }
    }
}