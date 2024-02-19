using ChainOfResponsability.Entities;
using ChainOfResponsability.Receivers;

var order = new Order();

var align = new AlignReceiver();
var tires = new TiresReceiver();
var hammer = new GoldHammerReceiver();
var paint = new PaintReceiver();

align.AddNext(tires)
     .AddNext(hammer)
     .AddNext(paint);

align.AddServiceInOrder(order);

Console.WriteLine($"Items: {string.Join(", ", order.GetItems())}");
Console.WriteLine($"Total: {order.GetTotal()}");