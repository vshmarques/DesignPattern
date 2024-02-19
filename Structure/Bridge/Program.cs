using Bridge.Abstraction;
using Bridge.Implementation;

var material = new Pen()
{
    Color = new Blue()
};
Console.WriteLine(material.Find());

var material2 = new Pencil()
{
    Color = new Red()
};
Console.WriteLine(material2.Find());

var material3 = new Pencil()
{
    Color = new Blue()
};
Console.WriteLine(material3.Find());

var material4 = new Pen()
{
    Color = new Red()
};
Console.WriteLine(material4.Find());

Console.ReadLine();