using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core
{
    public class SubtitlesParser : IParser
    {
        class EntriesArray
        {
            [JsonInclude]
            [JsonPropertyName("femaleVariant")]
            public string FemaleVariant;

            [JsonInclude]
            [JsonPropertyName("maleVariant")]
            public string MaleVariant;

            [JsonInclude]
            [JsonPropertyName("stringId")]
            public string StringId;
        }

        class Entry
        {
            [JsonInclude]
            [JsonPropertyName("entries")]
            public List<EntriesArray> Entries;
        }

        private readonly ICR2WExport _chunk;

        public SubtitlesParser(ICR2WExport chunk)
        {
            _chunk = chunk;
        }

        public object GetData()
        {
            var output = new Entry();

            foreach (var v in _chunk.data.ChildrEditableVariables)
            {
                //"entries":
                output.Entries = GetMetaData(v);
            }

            return output;
        }

        private List<EntriesArray> GetMetaData(IEditableVariable evar)
        {
            var metaList = new List<EntriesArray>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var obj = new EntriesArray();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var rv = editableVariable.REDValue;
                    switch (editableVariable.REDName)
                    {
                        case "femaleVariant":
                            obj.FemaleVariant = rv != null ? rv : "";
                            break;
                        case "maleVariant":
                            obj.MaleVariant = rv != null ? rv : "";
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
