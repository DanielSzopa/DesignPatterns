using Strategy;

IRouteStrategy walkStrategy = new WalkStrategy();
IRouteStrategy bikeStrategy = new BikeStrategy();
IRouteStrategy carStrategy = new CarStrategy();



IMap map_walk = new Map(walkStrategy);
IMap map_bike = new Map(bikeStrategy);
IMap map_car = new Map(carStrategy);

var start = new Coordinate() { Lat = 10, Long = 20 };
var end = new Coordinate() { Lat = 50, Long = 202 };

map_walk.CreateRoute(start, end);
map_bike.CreateRoute(start, end);
map_car.CreateRoute(start, end);