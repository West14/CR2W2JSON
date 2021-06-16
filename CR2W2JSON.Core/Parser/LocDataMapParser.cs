using System.Collections.Generic;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class LocDataMapParser : IParser
    {
        private readonly ICR2WExport _chunk;

        public LocDataMapParser(ICR2WExport chunk)
        {
            _chunk = chunk;
        }

        public object GetData() => new Dictionary<string, List<Dictionary<string, string>>>
        {
            {"entries", GetLocDataMapEntries(_chunk.data.ChildrEditableVariables[0])}
        };

        private List<Dictionary<string, string>> GetLocDataMapEntries(IEditableVariable evar)
        {
            var entries = new List<Dictionary<string, string>>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var entry = new Dictionary<string, string>();
                foreach (var ev in sVariable.ChildrEditableVariables)
                {
                    entry.Add(ev.REDName, ev.REDValue.Replace("[Soft]", ""));
                }
                entries.Add(entry);
            }

            return entries;
        }
    }
}
