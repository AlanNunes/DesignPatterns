using AbstractFacotryPattern.Factories;
using AbstractFacotryPattern.Factories.Variants;

IFornitureFactory factory;

Console.WriteLine("Type one of the following forniture variants:");
Console.WriteLine("1 - ArtDeco");
Console.WriteLine("2 - Victorian");
var userChoice = Convert.ToInt16(Console.ReadLine());

switch ((FornitureFactoryType)userChoice)
{
    case FornitureFactoryType.ArtDeco:
        factory = new ArtDecoFornitureFactory();
        break;
    case FornitureFactoryType.Victorian:
        factory = new VictorianFornitureFactory();
        break;
    default:
        throw new Exception();
}

var sofa = factory?.CreateSofa();
sofa?.SitOn();
sofa?.LayOn();

var chair = factory?.CreateChair();
chair?.SitOn();