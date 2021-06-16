using System.Collections.Generic;
using System.Runtime.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class VoMapParser : AbstractParser
    {
        public override ISerializable GetData() =>
            GetEntriesDictionary(GetVoMapEntries(Chunk.data.ChildrEditableVariables[0]));

        private List<Dictionary<string, dynamic>> GetVoMapEntries(IEditableVariable evar)
        {
            var entries = new List<Dictionary<string, dynamic>>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var entry = new Dictionary<string, dynamic>();
                foreach (var ev in sVariable.ChildrEditableVariables)
                {
                    var name = ev.REDName;
                    var rv = ev.REDValue;
                    entry.Add(name, name == "stringId" ? $"{ulong.Parse(rv):X}" : rv.Replace("[Soft]", ""));
                    
                }
                entries.Add(entry);
            }

            return entries;
        }

        public VoMapParser(ICR2WExport chunk) : base(chunk) {}
    }
}
