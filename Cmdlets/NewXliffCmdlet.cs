using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Xml.Serialization;

namespace UncommonSense.Xliff.Cmdlets
{
    [Cmdlet(VerbsCommon.New, "Xliff")]
    [OutputType(typeof(FileInfo))]
    public class NewXliffCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Path { get; set; }

        [Parameter(Mandatory = true, Position = 1)]
        public string SourceLanguage { get; set; }

        [Parameter(Mandatory = true, Position = 2)]
        public string TargetLanguage { get; set; }

        [Parameter()]
        public string Original { get; set; }

        [Parameter()]
        public string DataType { get; set; }

        protected override void EndProcessing()
        {
            var xliffDocument = new XliffDocument();
            var serializer = new XmlSerializer(typeof(XliffDocument));
            var path = GetUnresolvedProviderPathFromPSPath(Path);

            xliffDocument.Files.Add(new XliffFile
            {
                SourceLanguage = SourceLanguage,
                TargetLanguage = TargetLanguage,
                Original = Original,
                DataType = DataType
            });

            xliffDocument.Files.First().Body.Contents.Add(new XliffGroup() { ID = "body" });

            using (var streamWriter = new StreamWriter(path))
            {
                serializer.Serialize(streamWriter, xliffDocument);
            }

            WriteObject(new FileInfo(path));
        }
    }
}