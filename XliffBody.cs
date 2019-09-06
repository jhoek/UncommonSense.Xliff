using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public class XliffBody
    {
        [XmlElement("group", typeof(XliffGroup))]
        [XmlElement("trans-unit", typeof(XliffTranslationUnit))]
        public Collection<XliffContentNode> Contents { get; } = new Collection<XliffContentNode>();
        public IEnumerable<XliffTranslationUnit> TranslationUnits => Contents.OfType<XliffTranslationUnit>();
        public IEnumerable<XliffGroup> Groups => Contents.OfType<XliffGroup>();
    }
}