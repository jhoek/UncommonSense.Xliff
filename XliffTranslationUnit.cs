using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public class XliffTranslationUnit : XliffContentNode
    {
        [XmlAttribute("id")] public string ID { get; set; }
        [XmlElement("source")] public string Source { get; set; }
        [XmlElement("target")] public string Target { get; set; }
        [XmlAttribute("size-unit")] public XliffSizeUnit SizeUnit { get; set; }
        [XmlAttribute("translate")] public XliffBoolean Translate { get; set; }
        [XmlAttribute("xml:space")] public XmlSpace Space { get; set; }
        [XmlElement("note")] public Collection<XliffNote> Notes { get; set; }
    }
}