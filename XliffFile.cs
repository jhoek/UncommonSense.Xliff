using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public class XliffFile
    {
        internal XliffFile() { }

        [XmlAttribute("datatype")] public string DataType { get; set; }
        [XmlAttribute("source-language")] public string SourceLanguage { get; set; }
        [XmlAttribute("target-language")] public string TargetLanguage { get; set; }
        [XmlAttribute("original")] public string Original { get; set; }
        [XmlElement("body")] public XliffBody Body { get; set; } = new XliffBody();
    }
}