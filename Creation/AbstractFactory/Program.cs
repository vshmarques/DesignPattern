
using AbstractFactory.Factories;

Console.WriteLine("Getting a BigMac Combo:");
var comboBigMac = new BigMacComboFactory();

Console.WriteLine("");

Console.WriteLine("Getting a Tasty Combo:");
var comboTasty = new TastyComboFactory();