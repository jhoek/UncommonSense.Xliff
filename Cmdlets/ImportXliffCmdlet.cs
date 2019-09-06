using System.IO;
using System.Management.Automation;
using System.Xml.Serialization;

namespace UncommonSense.Xliff.Cmdlets
{
    [Cmdlet(VerbsData.Import, "Xliff")]
    [OutputType(typeof(XliffDocument))]
    public class ImportXliffCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Path { get; set; }

        protected override void EndProcessing()
        {
            var serializer = new XmlSerializer(typeof(XliffDocument));

            foreach (var path in GetResolvedProviderPathFromPSPath(Path, out ProviderInfo provider))
            {
                using (var streamReader = new StreamReader(path))
                {
                    WriteObject((XliffDocument)(serializer.Deserialize(streamReader)));
                }
            }
        }
    }
}