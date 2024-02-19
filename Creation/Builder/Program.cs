using Builder;
using Builder.Builders;
using Builder.Cars;

var carBuilder = new CarBuilder();
CarBuilderBase carBuilderBase;
Car car;

carBuilderBase = new Car1000CcBuilder();
carBuilder.BuildCar(carBuilderBase);
car = carBuilderBase.GetCar();


Console.WriteLine($"Car created, CC: {car.CC}, Color: {car.Color}, Price: {car.Price}");

carBuilderBase = new Car1500CcBuilder();
carBuilder.BuildCar(carBuilderBase);
car = carBuilderBase.GetCar();

Console.WriteLine($"Car created, CC: {car.CC}, Color: {car.Color}, Price: {car.Price}");