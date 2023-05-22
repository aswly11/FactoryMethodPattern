
using FactoryMethodPattern;

IVehicleFactory vehicleFactory = new VehicleFactory();

var car = vehicleFactory.CreateVehicle("Car");
var truck = vehicleFactory.CreateVehicle("Truck");

car.drive();
truck.drive();
