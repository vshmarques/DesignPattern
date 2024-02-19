using TemplateMethod;
using TemplateMethod.Mock;

Console.WriteLine("From JSON");
var json = Mock.GetJson();
var processFromJson = new ProccessPersonJSON(json);
processFromJson.ShowValues();

Console.WriteLine("From XML");
var xml = Mock.GetXml();
var processFromXml = new ProccessPersonXML(xml);
processFromXml.ShowValues();