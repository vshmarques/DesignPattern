using Memento;

var light = new Originator();
light.Status = "turned off";

var caretaker = new Caretaker();
caretaker.AddSnapshot(light.CreateSnapshot());

light.Status = "turned on";

light.Restore(caretaker.GetSnapshot());