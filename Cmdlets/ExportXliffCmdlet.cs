using System.IO;
using System.Management.Automation;
using System.Xml.Serialization;

namespace UncommonSense.Xliff.Cmdlets
{
    [Cmdlet(VerbsData.Export, "Xliff")]
    [OutputType(typeof(FileInfo))]
    public class ExportXliffCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public XliffDocument InputObject { get; set; }

        [Parameter(Mandatory = true, Position = 0)]
        public string Path { get; set; }

        protected override void EndProcessing()
        {
            var serializer = new XmlSerializer(typeof(XliffDocument));
            var path = GetUnresolvedProviderPathFromPSPath(Path);

            using (var streamWriter = new StreamWriter(path))
            {
                serializer.Serialize(streamWriter, InputObject);
            }

            WriteObject(new FileInfo(path));
        }
    }
}