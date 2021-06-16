using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class StringIdVariantLengthsReportParser : IParser
    {
        class Entry
        {
            [JsonInclude]
            [JsonPropertyName("femaleLength")]
            public float FemaleLength;

            [JsonInclude]
            [JsonPropertyName("maleLength")]
            public float MaleLength;

            [JsonInclude]
            [JsonPropertyName("stringId")]
            public string StringId;
        }

        class EntriesArray
        {
            [JsonInclude]
            [JsonPropertyName("entries")]
            public List<Entry> Entries;
        }

        private readonly ICR2WExport _chunk;

        public StringIdVariantLengthsReportParser(ICR2WExport chunk)
        {
            _chunk = chunk;
        }

        public object GetData()
        {
            var output = new EntriesArray();

            foreach (var v in _chunk.data.ChildrEditableVariables)
            {
                //"entries":
                output.Entries = GetMetaData(v);
            }

            return output;
        }

        private List<Entry> GetMetaData(IEditableVariable evar)
        {
            var metaList = new List<Entry>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var obj = new Entry();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var rv = editableVariable.REDValue;
                    switch (editableVariable.REDName)
                    {
                        case "femaleLength":
                              obj.FemaleLength = float.Parse(rv);
                            break;
                        case "maleLength":
                            obj.MaleLength = float.Parse(rv);
                            break;
                        case "stringId":
                            obj.StringId = $"{ulong.Parse(rv):X}";
                            break;
                    }
                }
                metaList.Add(obj);
            }

            return metaList;
        }
    }
}
