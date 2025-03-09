using AbstractFacotryPattern.ConcreteProducts;
using AbstractFacotryPattern.Products;

namespace AbstractFacotryPattern.Factories.Variants
{
    internal class VictorianFornitureFactory : IFornitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}