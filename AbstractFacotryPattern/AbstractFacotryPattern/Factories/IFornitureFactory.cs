using AbstractFacotryPattern.Products;

namespace AbstractFacotryPattern.Factories
{
    internal interface IFornitureFactory
    {
        ISofa CreateSofa();
        IChair CreateChair();
    }
}