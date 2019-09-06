using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public class XliffTranslationUnit : XliffContentNode
    {
        [XmlAttribute("id")] public string ID { get; set; }
        [XmlElement("source")] public string Source { get; set; }
        [XmlElement("target")] public string Target { get; set; }
    }
}