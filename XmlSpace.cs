using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public enum XmlSpace
    {
        [XmlEnum("default")] Default,
        [XmlEnum("preserve")] Preserve
    }
}