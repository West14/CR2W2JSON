using System.Collections.Generic;
using System.Runtime.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class LocDataMapAbstractParser : AbstractParser
    {
        public override ISerializable GetData() =>
            GetEntriesDictionary(GetLocDataMapEntries(Chunk.data.ChildrEditableVariables[0]));

        private List<Dictionary<string, dynamic>> GetLocDataMapEntries(IEditableVariable evar)
        {
            var entries = new List<Dictionary<string, dynamic>>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var entry = new Dictionary<string, dynamic>();
                foreach (var ev in sVariable.ChildrEditableVariables)
                {
                    entry.Add(ev.REDName, ev.REDValue.Replace("[Soft]", ""));
                }
                entries.Add(entry);
            }

            return entries;
        }

        public LocDataMapAbstractParser(ICR2WExport chunk) : base(chunk) {}
    }
}
