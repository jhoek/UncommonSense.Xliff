using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;
using UncommonSense.Xliff.Helpers;

namespace UncommonSense.Xliff
{
    [XmlRoot("xliff", Namespace = "urn:oasis:names:tc:xliff:document:1.2")]
    public class XliffDocument
    {
        public const XliffVersion DefaultVersion = XliffVersion.Version12;
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")] public string SchemaLocation { get; set; } = "urn:oasis:names:tc:xliff:document:1.2 xliff-core-1.2-transitional.xsd";

        [XmlAttribute("version")] public XliffVersion Version { get; set; } = DefaultVersion;

        [XmlElement("file")] public Collection<XliffFile> Files { get; } = new Collection<XliffFile>();

        public IEnumerable<XliffTranslationUnit> TranslationUnits =>
            Files
                .SelectMany(f => f.Body.Contents.OfType<XliffTranslationUnit>())
                .Concat(Files.SelectMany(f => f.Body.Contents.OfType<XliffGroup>().SelectMany(g => g.ToTranslationUnits())));
    }
}
