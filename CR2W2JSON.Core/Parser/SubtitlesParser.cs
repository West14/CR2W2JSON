using System.Collections.Generic;
using System.Runtime.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class SubtitlesParser : AbstractParser
    {
        public override ISerializable GetData()
        {
            return GetEntriesDictionary(GetMetaData(Chunk.data.ChildrEditableVariables[0]));
        }

        private List<Dictionary<string, dynamic>> GetMetaData(IEditableVariable evar)
        {
            var entries = new List<Dictionary<string, dynamic>>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var obj = new Dictionary<string, dynamic>();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var redName = editableVariable.REDName;
                    var redValue = editableVariable.REDValue;
                    obj.Add(redName, redName == "stringId" ? $"{ulong.Parse(redValue):X}" : redValue ?? "");
                }
                entries.Add(obj);
            }

            return entries;
        }

        public SubtitlesParser(ICR2WExport chunk) : base(chunk) {}
    }
}
