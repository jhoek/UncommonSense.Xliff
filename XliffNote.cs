using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public class XliffNote
    {
        [XmlAttribute("from")] public string From { get; set; }
        [XmlAttribute("annotates")] public XliffAnnotates Annotates { get; set; }
        [XmlAttribute("priority")] public int Priority { get; set; }
        [XmlText()] public string Value { get; set; }
    }
}