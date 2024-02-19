using Iterator;

var aggregate = new Aggregate();

aggregate[0] = "Item 01";
aggregate[0] = "Item 02";
aggregate[0] = "Item 03";
aggregate[0] = "Item 04";
aggregate[0] = "Item 05";

var iterator = aggregate.GetIterator();

for (string item = iterator.Next; iterator.HasNext; item= iterator.Next)
{
    Console.WriteLine(item);
}