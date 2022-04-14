using FurniutureAbstractFactory.Factory;
using FurniutureAbstractFactory.ModernFurniture;

IFactory modernFactory = new ModernFactory();
IFactory standardFactory = new StandardFactory();

var appModern = new FurniutureAbstractFactory.Application(modernFactory);
var appStandard = new FurniutureAbstractFactory.Application(standardFactory);


appModern.CreateCollection();
appStandard.CreateCollection();