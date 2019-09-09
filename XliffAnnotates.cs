using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public enum XliffAnnotates
    {
        [XmlEnum("source")] Source,
        [XmlEnum("target")] Target,
        [XmlEnum("general")] General
    }
}