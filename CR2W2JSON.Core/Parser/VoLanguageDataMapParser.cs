using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class VoLanguageDataMapParser : AbstractParser
    {
        public override ISerializable GetData()
        {
            return GetEntriesDictionary(GetMetaData(Chunk.data.ChildrEditableVariables[0]));
        }

        private List<Dictionary<string, dynamic>> GetMetaData(IEditableVariable evar)
        {
            var metaList = new List<Dictionary<string, dynamic>>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var obj = new Dictionary<string, dynamic>();
                var voMapChunks = new List<string>();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var redValue = editableVariable.REDValue;
                    var redName = editableVariable.REDName;
                    switch (redName)
                    {
                        case "languageCode":
                            obj.Add(redName, redValue);
                            break;
                        case "lenghtMapReport":
                        case "voiceverMapReport":
                            obj.Add(redName, redValue.Replace("[Default]", " ").Replace("[Soft]", ""));
                            break;
                        case "voMapChunks":
                            foreach (var entrs in editableVariable.ChildrEditableVariables)
                            {
                                voMapChunks.Add(entrs.REDValue.Replace("[Soft]", ""));
                            }
                            break;
                    }
                }
                metaList.Add(obj);
            }

            return metaList;
        }

        public VoLanguageDataMapParser(ICR2WExport chunk) : base(chunk) {}
    }
}
