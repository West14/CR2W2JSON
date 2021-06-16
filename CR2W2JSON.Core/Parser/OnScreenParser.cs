using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public class OnScreenParser : AbstractParser
    {
        public override ISerializable GetData()
        {
            var entries = new List<Dictionary<string, dynamic>>();
            
            foreach (var childr in Chunk.data.ChildrEditableVariables[0].ChildrEditableVariables)
            {
                var entry = new Dictionary<string, dynamic>();
                foreach (var ev in childr.ChildrEditableVariables)
                {
                    switch (ev.REDName)
                    {
                        case "primaryKey":
                            entry.Add(ev.REDName, UInt64.Parse(ev.REDValue));
                            break;
                        case "secondaryKey":
                        case "femaleVariant":
                        case "maleVariant":
                            entry.Add(ev.REDName, ev.REDValue ?? "");
                            break;
                    }
                }
                
                entries.Add(entry);
            }

            return GetEntriesDictionary(entries);
        }

        public OnScreenParser(ICR2WExport chunk) : base(chunk) {}
    }
}