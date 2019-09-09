using System.ComponentModel;
using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public class XliffTarget
    {
        [DefaultValueAttribute(XliffState.Unspecified)] [XmlAttribute("state")] public XliffState State { get; set; }
        [XmlText()] public string Value { get; set; }

        public override string ToString() => Value;
    }
}