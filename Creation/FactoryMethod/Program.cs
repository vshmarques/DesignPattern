// See https://aka.ms/new-console-template for more information
using FactoryMethod;

var serviceOne = new ServiceBuilder().Build(FactoryMethod.Enums.EnumServiceType.One);
serviceOne.Execute();

var serviceTwo = new ServiceBuilder().Build(FactoryMethod.Enums.EnumServiceType.Two);
serviceTwo.Execute();

var serviceThree = new ServiceBuilder().Build(FactoryMethod.Enums.EnumServiceType.Three);
serviceThree.Execute();