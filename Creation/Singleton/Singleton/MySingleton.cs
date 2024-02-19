namespace Singleton;

public class MySingleton
{
	private static MySingleton _mySingleton = null;
	
	private MySingleton()
	{
		Console.WriteLine($"Intance of {nameof(MySingleton)} created.");
	}

	public static MySingleton Instance
	{
		get 
		{ 
			if (_mySingleton is null)
				_mySingleton = new MySingleton();

			return _mySingleton; 
		}
	}

	public void ExecuteSomething(string value)
	{
		Console.WriteLine(value);
	}
}
