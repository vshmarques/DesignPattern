using TemplateMethod.Entities;

namespace TemplateMethod.Abstractions;

public abstract class ProccessPerson
{
	protected List<Person> _persons;
	protected string _xml;
	protected string _json;

	public ProccessPerson(string xml="", string json="")
	{
		_xml = xml;
		_json = json;

		_persons = new List<Person>();
	}

	protected virtual void ProccessXML() { }
	protected virtual void ProccessJSON() { }

	public void ShowValues()
	{
		_persons.ForEach(person =>
		{
			Console.WriteLine($"Id:{person.Id}");
			Console.WriteLine($"Name:{person.Name}");
			Console.WriteLine($"Age:{person.Age}");
			Console.WriteLine(new String('-', 40));
		});
	}
}
