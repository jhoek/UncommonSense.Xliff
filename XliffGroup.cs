using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public class XliffGroup : XliffContentNode
    {
        [XmlAttribute("id")] public string ID { get; set; }

        [XmlElement("group", typeof(XliffGroup))]
        [XmlElement("trans-unit", typeof(XliffTranslationUnit))]
        public Collection<XliffContentNode> Contents { get; } = new Collection<XliffContentNode>();
        [XmlElement("note")] public Collection<XliffNote> Notes { get; set; }
        public IEnumerable<XliffTranslationUnit> TranslationUnits => Contents.OfType<XliffTranslationUnit>();
        public IEnumerable<XliffGroup> Groups => Contents.OfType<XliffGroup>();
    }
}