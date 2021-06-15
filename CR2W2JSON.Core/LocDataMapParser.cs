using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core
{
    public class LocDataMapParser : IParser
    {
        class Entry
        {
            [JsonInclude]
            [JsonPropertyName("langCode")]
            public string LangCode;

            [JsonInclude]
            [JsonPropertyName("onscreensPath")]
            public string OnscreensPath;

            [JsonInclude]
            [JsonPropertyName("subtitlePath")]
            public string SubtitlePath;
        }

        class EntriesArray
        {
            [JsonInclude]
            [JsonPropertyName("entries")]
            public List<Entry> Entries;
        }

        private readonly ICR2WExport _chunk;

        public LocDataMapParser(ICR2WExport chunk)
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
                        case "langCode":
                            obj.LangCode = rv;
                            break;
                        case "onscreensPath":
                            obj.OnscreensPath = rv.Replace("[Soft]", "");
                            break;
                        case "subtitlePath":
                            obj.SubtitlePath = rv.Replace("[Soft]", "");
                            break;
                    }
                }
                metaList.Add(obj);
            }

            return metaList;
        }
    }
}
