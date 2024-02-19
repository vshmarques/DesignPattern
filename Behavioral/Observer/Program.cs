using Observer.Observers;
using Observer.Subjects;

var subject = new Blog();

var observer1 = new Assigners("User 1", "");
var observer2 = new Assigners("User 2", "");

subject.Add(observer1, observer2);

Enumerable.Range(0, 10).ToList().ForEach(subject.Notify);