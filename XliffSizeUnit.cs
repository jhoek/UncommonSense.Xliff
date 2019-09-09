using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public enum XliffSizeUnit
    {
        [XmlEnum("byte")] Byte,
        [XmlEnum("char")] Char,
        [XmlEnum("col")] Col,
        [XmlEnum("cm")] Cm,
        [XmlEnum("dlgunit")] DlgUnit,
        [XmlEnum("em")] Em,
        [XmlEnum("ex")] Ex,
        [XmlEnum("glyph")] Glyph,
        [XmlEnum("in")] In,
        [XmlEnum("mm")] Mm,
        [XmlEnum("percent")] Percent,
        [XmlEnum("pixel")] Pixel,
        [XmlEnum("point")] Point,
        [XmlEnum("row")] Row
    }
}