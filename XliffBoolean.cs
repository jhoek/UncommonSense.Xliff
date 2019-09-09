using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public enum XliffBoolean
    {
        [XmlEnum("no")] No,
        [XmlEnum("yes")] Yes,
    }
}