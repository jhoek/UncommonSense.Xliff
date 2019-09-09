using System.Xml.Serialization;

namespace UncommonSense.Xliff
{
    public enum XliffState
    {
        [XmlEnum("x-unspecified")] Unspecified,
        [XmlEnum("final")] Final,
        [XmlEnum("needs-adaptation")] NeedsAdaptation,
        [XmlEnum("needs-l10n")] NeedsLocalization,
        [XmlEnum("needs-review-adaptation")] NeedsReviewAdaptation,
        [XmlEnum("needs-review-l10n")] NeedsReviewLocalization,
        [XmlEnum("needs-review-translation")] NeedsReviewTranslation,
        [XmlEnum("needs-translation")] NeedsTranslation,
        [XmlEnum("new")] New,
        [XmlEnum("signed-off")] SignedOff,
        [XmlEnum("translated")] Translated
    }
}