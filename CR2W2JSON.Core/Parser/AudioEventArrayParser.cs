using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    class AudioEventArray
    {
        [JsonInclude] [JsonPropertyName("isSortedByRedHash")] public bool IsSortedByRedHash = true;
        [JsonInclude] [JsonPropertyName("events")] public List<EventMetaData> Events;
        [JsonInclude] [JsonPropertyName("switchGroup")] public List<EventMetaData> SwitchGroup;
    
        [JsonInclude] [JsonPropertyName("switch")] public List<EventMetaData> Switch;
        [JsonInclude] [JsonPropertyName("stateGroup")] public List<EventMetaData> StateGroup;
        [JsonInclude] [JsonPropertyName("state")] public List<EventMetaData> State;
        [JsonInclude] [JsonPropertyName("gameParameter")] public List<EventMetaData> GameParameter;
        [JsonInclude] [JsonPropertyName("bus")] public List<EventMetaData> Bus;
    }
    
    class EventMetaData
    {
        [JsonInclude] [JsonPropertyName("redId")] public string RedId;
        [JsonInclude] [JsonPropertyName("wwiseId")] public UInt32 WwiseId;
        [JsonInclude] [JsonPropertyName("maxAttenuation")] public float MaxAttenuation;
        [JsonInclude] [JsonPropertyName("minDuration")] public float MinDuration;
        [JsonInclude] [JsonPropertyName("maxDuration")] public float MaxDuration;
        [JsonInclude] [JsonPropertyName("isLooping")] public bool IsLooping;
        [JsonInclude] [JsonPropertyName("stopActionEvents")] public List<string> StopActionEvents;
        [JsonInclude] [JsonPropertyName("tags")] public List<string> Tags;
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
                            obj.StopActionEvents = GetListFromEdVars(editableVariable.ChildrEditableVariables);
                            break;
                        case "tags":
                            obj.Tags = GetListFromEdVars(editableVariable.ChildrEditableVariables);
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
    }
}