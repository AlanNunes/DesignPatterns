using AbstractFacotryPattern.Products;

namespace AbstractFacotryPattern.ConcreteProducts
{
    internal class ArtDecoSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("You layed on Art Deco sofa.");
        }

        public void SitOn()
        {
            Console.WriteLine("You sat on Art Deco sofa.");
        }
    }
}