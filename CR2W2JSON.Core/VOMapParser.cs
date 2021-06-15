using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core
{
    public class VOMapParser : IParser
    {
        class EntriesArray
        {
            [JsonInclude]
            [JsonPropertyName("femaleResPath")]
            public string FemaleResPath;

            [JsonInclude]
            [JsonPropertyName("maleResPath")]
            public string MaleResPath;

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

        public VOMapParser(ICR2WExport chunk)
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
                        case "femaleResPath":
                            obj.FemaleResPath = rv.Replace("[Soft]", "");
                            break;
                        case "maleResPath":
                            obj.MaleResPath = rv.Replace("[Soft]", "");
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
