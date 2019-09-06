using System.Collections.Generic;
using System.Linq;

namespace UncommonSense.Xliff.Helpers
{
    public static class XliffGroupExtensionMethods
    {
        public static IEnumerable<XliffTranslationUnit> ToTranslationUnits(this XliffGroup group) =>
            group
                .Contents
                .OfType<XliffTranslationUnit>()
                .Concat(
                    group
                        .Contents
                        .OfType<XliffGroup>()
                        .SelectMany(g => g.ToTranslationUnits()));
    }
}