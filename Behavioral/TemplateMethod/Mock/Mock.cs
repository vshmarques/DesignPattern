using System.Text.Json;
using System.Xml.Serialization;
using TemplateMethod.Entities;

namespace TemplateMethod.Mock;

public class Mock
{
    public static string GetXml()
    {
        var persons= GetPersons();

        var serializer= new XmlSerializer(persons.GetType());
        var xml = string.Empty;

        using (var sw = new StringWriter())
        {
            serializer.Serialize(sw, persons);
            xml = sw.ToString();
        }

        return xml;
    }

    public static string GetJson() 
    { 
        return JsonSerializer.Serialize(GetPersons());
    }

    private static List<Person> GetPersons()
    {
        return new List<Person>()
        {
            new Person()
            {
                Id= 1,
                Name = "Bill Gates",
                Age= 30,
            },
            new Person()
            {
                Id= 2,
                Name = "Marcos Zuchenberg",
                Age= 34,
            },
            new Person()
            {
                Id= 1,
                Name = "Ellon Musk",
                Age= 54,
            }
        };
    }
}
