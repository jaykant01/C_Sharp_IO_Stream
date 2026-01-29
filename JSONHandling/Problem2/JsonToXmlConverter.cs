using Newtonsoft.Json;
using System;
using System.Xml;
namespace JSONHandling;

public class JsonToXmlConverter
{
    public static void Convert()
    {
        string json = @"{ 'student': { 'name':'Amit', 'age':22 } }";

        XmlDocument doc = JsonConvert.DeserializeXmlNode(json);
        Console.WriteLine("\nJSON to XML:\n" + doc.OuterXml);
    }
}
