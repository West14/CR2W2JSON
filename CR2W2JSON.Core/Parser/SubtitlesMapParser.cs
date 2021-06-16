using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class SubtitlesMapParser : IParser
    {
        public class Entry
        {
            [JsonInclude]
            [JsonPropertyName("subtitleFile")]
            public string SubtitleFile;

            [JsonInclude]
            [JsonPropertyName("subtitleGroup")]
            public string SubtitleGroup;
        }

        class EntriesArray
        {
            [JsonInclude]
            [JsonPropertyName("entries")]
            public List<Entry> Entries;
        }

        private readonly ICR2WExport _chunk;
        private List<Entry> entries;

        public SubtitlesMapParser(ICR2WExport chunk)
        {
            _chunk = chunk;
        }

        public object GetData()
        {
            var output = new EntriesArray();

            foreach (var v in _chunk.data.ChildrEditableVariables)
            {
                //"entries":
                entries = GetMetaData(v);
                output.Entries = entries;
            }

            return output;
        }

        public List<Entry> GetEntries()
        {
            return entries;
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
                        case "subtitleFile":
                            obj.SubtitleFile = rv.Replace("[Soft]", "");
                            break;
                        case "subtitleGroup":
                            obj.SubtitleGroup = rv;
                            break;
                    }
                }
                metaList.Add(obj);
            }

            return metaList;
        }
    }
}
