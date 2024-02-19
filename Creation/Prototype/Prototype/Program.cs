using Prototype;

var user = new User("User 1", "user1@gmail.com");

var userCloned = user.Clone();

Console.WriteLine(userCloned.ToString());