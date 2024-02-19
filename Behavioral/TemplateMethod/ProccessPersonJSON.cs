using System.Text.Json;
using TemplateMethod.Abstractions;
using TemplateMethod.Entities;

namespace TemplateMethod;

public class ProccessPersonJSON : ProccessPerson
{
	public ProccessPersonJSON(string json) : base(json:json)
	{
        ProccessJSON();
    }

    protected override void ProccessJSON()
    {
        this._persons = JsonSerializer.Deserialize<List<Person>>(this._json);
    }
}
