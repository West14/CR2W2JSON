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

        public object GetData()
        {
            return new Dictionary<string, List<Dictionary<string, string>>>
            {
                {"entries", GetLocDataMapEntries(_chunk.data.ChildrEditableVariables[0])}
            };
        }

        private List<Dictionary<string, string>> GetLocDataMapEntries(IEditableVariable evar)
        {
            var metaList = new List<Dictionary<string, string>>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var obj = new Dictionary<string, string>();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var rv = editableVariable.REDValue;
                    obj.Add(editableVariable.REDName, rv.Replace("[Soft]", ""));
                }

                metaList.Add(obj);
            }

            return metaList;
        }
    }
}
