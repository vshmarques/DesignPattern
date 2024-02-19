using System.Xml;
using System.Xml.Serialization;
using TemplateMethod.Abstractions;
using TemplateMethod.Entities;

namespace TemplateMethod;

public class ProccessPersonXML : ProccessPerson
{
	public ProccessPersonXML(string xml) : base(xml:xml)
	{
        ProccessXML();
	}

    protected override void ProccessXML()
    {
        var serializer = new XmlSerializer(this._persons.GetType());
        var stringReader = new StringReader(this._xml);

        using (var reader = XmlReader.Create(stringReader))
        {
            this._persons = serializer.Deserialize(reader) as List<Person>;
        }
    }
}
