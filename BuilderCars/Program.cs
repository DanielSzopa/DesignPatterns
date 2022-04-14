using BuilderCars.Builder;
using BuilderCars.Builder.Interfaces;

ICarBuilder customCarBuilder = new CarBuilder();
ICarBuilder sportCarBuilder = new CarBuilder();
ICarBuilder comfortCarBuilder = new CarBuilder();

ISportCarDirector sportCarDirector = new CarDirector(sportCarBuilder);
IComfortCarDirector comfortCarDirector = new CarDirector(comfortCarBuilder);

var customCar = customCarBuilder
    .CreateBuilder()
    .SetModel("Audi A7")
    .SetDateProduction(new DateTime(2000,12,12))
    .SetWheel("Wheel Stir")
    .SetSportConfiguration(true, false)
    .SetComfortConfiguration(false,false,true)
    .Build();



var sportCar = sportCarDirector
    .BuildSportCar("BMW Sport", new DateTime(2022, 01, 01), "BmwWheel");

var comfortCar = comfortCarDirector
    .BuildComfortCar("Maybach", new DateTime(2006, 01, 01), "ComfortWheel");



Console.ReadKey();


