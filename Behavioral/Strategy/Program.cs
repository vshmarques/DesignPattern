using Strategy.Interfaces;
using Strategy.Models;
using Strategy.Services;

var order1 = new Order(new Guid(), "order 1", 50.0, 3);
var order2 = new Order(new Guid(), "order 2", 150.0, 32);
var order3 = new Order(new Guid(), "order 3", 20.0, 5);
var order4 = new Order(new Guid(), "order 4", 150.0, 15);

var service1 = new StandardService(order1);
var service2 = new StandardService(order2);
var service3 = new PremiumService(order3);
var service4 = new PremiumService(order4);

var services = new List<IService> { service1, service2, service3, service4 };

services.ForEach(service => service.CalculateService());