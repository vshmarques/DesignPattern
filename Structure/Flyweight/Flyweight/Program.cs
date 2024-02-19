
using Flyweight;

var factory = new CarFactory();

var car1 = factory.BuildCar("red");
car1.Show("running");

var car2 = factory.BuildCar("blue");
car2.Show("running at 160 mph");

var car3 = factory.BuildCar("red");
car3.Show("slow");

var car4 = factory.BuildCar("blue");
car4.Show("stoped");

var car5 = factory.BuildCar("red");
car5.Show("flying");

var car6 = factory.BuildCar("blue");
car6.Show("crash");

Console.ReadLine();