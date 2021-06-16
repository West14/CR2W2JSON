using System.Collections.Generic;
using System.Runtime.Serialization;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W;

namespace CR2W2JSON.Core.Parser
{
    public class StringIdVariantLengthsReportParser : AbstractParser
    {
        public override ISerializable GetData()
        {
            return GetEntriesDictionary(GetReportEntries(Chunk.data.ChildrEditableVariables[0]));
        }

        private List<Dictionary<string, dynamic>> GetReportEntries(IEditableVariable evar)
        {
            var metaList = new List<Dictionary<string, dynamic>>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var entry = new Dictionary<string, dynamic>();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var redValue = editableVariable.REDValue;
                    var redName = editableVariable.REDName;
                    entry.Add(redName, redName == "stringId" ? $"{ulong.Parse(redValue):X}" : float.Parse(redValue));

                }
                metaList.Add(entry);
            }

            return metaList;
        }

        public StringIdVariantLengthsReportParser(ICR2WExport chunk) : base(chunk) {}
    }
}
