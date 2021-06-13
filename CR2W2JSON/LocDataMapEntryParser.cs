using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON
{
    public class LocDataMapEntryParser : IParser
    {
        class EntriesArray
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

        class Entry
        {
            [JsonInclude]
            [JsonPropertyName("entries")]
            public List<EntriesArray> Entries;
        }

        private readonly ICR2WExport _chunk;

        public LocDataMapEntryParser(ICR2WExport chunk)
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
