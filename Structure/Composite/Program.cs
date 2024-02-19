
using Composite;

var pen = new ProductLeaf("Pen", 5.45);
var book = new ProductLeaf("Book", 21.90);
var eraser = new ProductLeaf("Eraser", 4);
var smallBox = new ProductComposite();
smallBox.Add(pen, book, eraser);

var statue = new ProductLeaf("Liberty Statue", 1500);
var largeBox = new ProductComposite();
largeBox.Add(smallBox, statue);

var total = largeBox.Operation();
Console.WriteLine($"Total: {total}");