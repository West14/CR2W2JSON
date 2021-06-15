using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core
{
    public class VOLanguageDataMapParser : IParser
    {
        class EntriesArray
        {
            [JsonInclude]
            [JsonPropertyName("languageCode")]
            public string LanguageCode;

            //there is a bug from REDs in naming: "lenghtMapReport" instead of "lengthMapReport"
            [JsonInclude]
            [JsonPropertyName("lenghtMapReport")]
            public string LengthMapReport;

            //there is a bug from REDs in naming: "voiceverMapReport" instead of "voiceoverMapReport"
            [JsonInclude]
            [JsonPropertyName("voiceverMapReport")]
            public string VoiceoverMapReport;

            [JsonInclude]
            [JsonPropertyName("voMapChunks")]
            public List<string> VoMapChunks;
        }

        class Entry
        {
            [JsonInclude]
            [JsonPropertyName("entries")]
            public List<EntriesArray> Entries;
        }

        private readonly ICR2WExport _chunk;

        public VOLanguageDataMapParser(ICR2WExport chunk)
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
                obj.VoMapChunks = new List<string>();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var rv = editableVariable.REDValue;
                    switch (editableVariable.REDName)
                    {
                        case "languageCode":
                            obj.LanguageCode = rv;
                            break;
                        case "lenghtMapReport":
                            obj.LengthMapReport = rv.Replace("[Soft]", "").Replace("[Default]", " ");
                            break;
                        case "voiceverMapReport":
                            obj.VoiceoverMapReport = rv.Replace("[Default]", " ").Replace("[Soft]", "");
                            break;
                        case "voMapChunks":
                            foreach (var entrs in editableVariable.ChildrEditableVariables)
                            {
                                obj.VoMapChunks.Add(entrs.REDValue.Replace("[Soft]", ""));
                            }
                            break;
                    }
                }
                metaList.Add(obj);
            }

            return metaList;
        }
    }
}
