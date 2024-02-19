using Decorator.Decorators;
using Decorator.Services;

var petGrooming = new PetGrooming();
var petCollar = new PetCollar(petGrooming);
var petSpa = new PetSpa(petCollar);

Console.WriteLine(petSpa.GetDescription());
Console.WriteLine(petSpa.GetPrice());