using AbstractFacotryPattern.Products;

namespace AbstractFacotryPattern.ConcreteProducts
{
    internal class ArtDecoChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("You sat on Art Deco chair.");
        }
    }
}