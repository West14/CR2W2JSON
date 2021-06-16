using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class AudioEventArrayParser : AbstractParser
    {
        public override ISerializable GetData()
        {
            return Chunk.data.ChildrEditableVariables.ToDictionary(
                v => v.REDName, v => GetMetaData(v)
                );
        }
        
        private List<Dictionary<string, dynamic>> GetMetaData(IEditableVariable evar)
        {
            var metaList = new List<Dictionary<string, dynamic>>();
            
            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var obj = new Dictionary<string, dynamic>();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var rv = editableVariable.REDValue;
                    var redName = editableVariable.REDName;
                    switch (editableVariable.REDName)
                    {
                        case "redId":
                            obj.Add(redName, rv);
                            break;
                        case "wwiseId":
                            obj.Add(redName, UInt32.Parse(rv));
                            break;
                        case "maxAttenuation":
                        case "minDuration":
                        case "maxDuration":
                            obj.Add(redName, float.Parse(rv));
                            break;
                        case "isLooping":
                            obj.Add(redName, bool.Parse(rv));
                            break;
                        case "stopActionEvents":
                        case "tags":
                            obj.Add(redName, GetListFromEdVars(editableVariable.ChildrEditableVariables));
                            break;
                    }
                } 
                metaList.Add(obj);
            }

            return metaList;
        }

        private List<string> GetListFromEdVars(List<IEditableVariable> vars)
        {
            var varList = new List<string>(); 
            foreach (var ev in vars)
            {
                varList.Add(ev.REDValue);
            }
            return varList;
        }
        
        public AudioEventArrayParser(ICR2WExport chunk) : base(chunk) {}
    }
}