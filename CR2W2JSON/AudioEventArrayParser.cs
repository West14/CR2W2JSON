using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON
{
    class AudioEventArray
    {
        [JsonInclude]
        [JsonPropertyName("isSortedByRedHash")]
        public bool IsSortedByRedHash = true;

        [JsonInclude]
        [JsonPropertyName("events")]
        public List<EventMetaData> Events;

        [JsonInclude]
        [JsonPropertyName("switchGroup")]
        public List<EventMetaData> SwitchGroup;
    
        [JsonInclude]
        [JsonPropertyName("switch")]
        public List<EventMetaData> Switch;
    
        [JsonInclude]
        [JsonPropertyName("stateGroup")]
        public List<EventMetaData> StateGroup;
    
        [JsonInclude]
        [JsonPropertyName("state")]
        public List<EventMetaData> State;
    
        [JsonInclude]
        [JsonPropertyName("gameParameter")]
        public List<EventMetaData> GameParameter;

        [JsonInclude] 
        [JsonPropertyName("bus")]
        public List<EventMetaData> Bus;
    }
    
    class EventMetaData
    {
        [JsonPropertyName("redId")]
        public string RedId { get; set; }
        [JsonPropertyName("wwiseId")]
        public UInt32 WwiseId { get; set; }
        [JsonPropertyName("maxAttenuation")]
        public float MaxAttenuation { get; set; }
        [JsonPropertyName("minDuration")]
        public float MinDuration { get; set; }
        [JsonPropertyName("maxDuration")]
        public float MaxDuration { get; set; }
        [JsonPropertyName("isLooping")]
        public bool IsLooping { get; set; }
        [JsonPropertyName("stopActionEvents")]
        public List<string> StopActionEvents { get; set; }
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    }
    
    public class AudioEventArrayParser : IParser
    {
        private readonly ICR2WExport _chunk;
        
        public AudioEventArrayParser(ICR2WExport chunk)
        {
            _chunk = chunk;
        }

        public object GetData()
        {
            var output = new AudioEventArray();
            
            foreach (var v in _chunk.data.ChildrEditableVariables)
            {
                switch (v.REDName)
                { 
                    case "events":
                        output.Events = GetMetaData(v);
                        break;

                    case "switchGroup":
                        output.SwitchGroup = GetMetaData(v);
                        break;

                    case "switch":
                        output.Switch = GetMetaData(v);
                        break;

                    case "stateGroup":
                        output.StateGroup = GetMetaData(v);
                        break;

                    case "state":
                        output.State = GetMetaData(v);
                        break;

                    case "gameParameter":
                        output.GameParameter = GetMetaData(v);
                        break;

                    case "bus":
                        output.Bus = GetMetaData(v);
                        break;
                }
            }

            return output;
        }
        
        private List<EventMetaData> GetMetaData(IEditableVariable evar)
        {
            var metaList = new List<EventMetaData>();
            
            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var obj = new EventMetaData();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var rv = editableVariable.REDValue;
                    switch (editableVariable.REDName)
                    {
                        case "redId":
                            obj.RedId = rv;
                            break;
                        case "wwiseId":
                            obj.WwiseId = UInt32.Parse(rv);
                            break;
                        case "maxAttenuation":
                            obj.MaxAttenuation = float.Parse(rv);
                            break;
                        case "minDuration":
                            obj.MinDuration = float.Parse(rv);
                            break;
                        case "maxDuration":
                            obj.MaxDuration = float.Parse(rv);
                            break;
                        case "isLooping":
                            obj.IsLooping = bool.Parse(rv);
                            break;
                        case "stopActionEvents":
                            var evList = new List<string>();
                            foreach (var ev in editableVariable.ChildrEditableVariables)
                            {
                                evList.Add(ev.REDValue);
                            }
                            obj.StopActionEvents = evList;
                            break;
                        case "tags":
                            var tagList = new List<string>();
                            foreach (var ev in editableVariable.ChildrEditableVariables)
                            {
                                tagList.Add(ev.REDValue);
                            }
                            obj.Tags = tagList;
                            break;
                    }
                } 
                metaList.Add(obj);
            }

            return metaList;
        }
    }
}