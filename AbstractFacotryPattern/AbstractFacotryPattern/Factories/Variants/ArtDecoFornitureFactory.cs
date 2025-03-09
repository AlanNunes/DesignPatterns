using AbstractFacotryPattern.ConcreteProducts;
using AbstractFacotryPattern.Products;

namespace AbstractFacotryPattern.Factories.Variants
{
    internal class ArtDecoFornitureFactory : IFornitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}