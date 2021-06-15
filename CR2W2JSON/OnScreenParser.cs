using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON
{
    class OnScreenEntries
    {
        [JsonInclude][JsonPropertyName("entries")]
        public List<OnScreenEntry> Entries = new();
    }
    
    class OnScreenEntry
    {
        [JsonInclude][JsonPropertyName("primaryKey")]
        public UInt64 PrimaryKey;
        
        [JsonInclude][JsonPropertyName("secondaryKey")]
        public string SecondaryKey;
        
        [JsonInclude][JsonPropertyName("femaleVariant")]
        public string FemaleVariant;
        
        [JsonInclude][JsonPropertyName("maleVariant")]
        public string MaleVariant;
    }
    
    public class OnScreenParser : IParser
    {
        private ICR2WExport _chunk;
        
        public OnScreenParser(ICR2WExport chunk)
        {
            _chunk = chunk;
        }

        public object GetData()
        {
            var entries = new OnScreenEntries();
            
            foreach (var childr in _chunk.data.ChildrEditableVariables[0].ChildrEditableVariables)
            {
                var entry = new OnScreenEntry();
                foreach (var ev in childr.ChildrEditableVariables)
                {
                    switch (ev.REDName)
                    {
                        case "primaryKey":
                            entry.PrimaryKey = UInt64.Parse(ev.REDValue);
                            break;
                        case "secondaryKey":
                            entry.SecondaryKey = ev.REDValue != null ? ev.REDValue : "";
                            break;
                        case "femaleVariant":
                            entry.FemaleVariant = ev.REDValue != null ? ev.REDValue : "";
                            break;
                        case "maleVariant":
                            entry.MaleVariant = ev.REDValue != null ? ev.REDValue : "";
                            break;
                    }
                }
                
                entries.Entries.Add(entry);
            }
            
            return entries;
        }
    }
}