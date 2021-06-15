﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON
{
    public class StringIDVariantLengthsReportParser : IParser
    {
        class EntriesArray
        {
            [JsonInclude]
            [JsonPropertyName("femaleLength")]
            public string FemaleLength;

            [JsonInclude]
            [JsonPropertyName("maleLength")]
            public string MaleLength;

            [JsonInclude]
            [JsonPropertyName("CRUID")]
            public string StringId;
        }

        class Entry
        {
            [JsonInclude]
            [JsonPropertyName("entries")]
            public List<EntriesArray> Entries;
        }

        private readonly ICR2WExport _chunk;

        public StringIDVariantLengthsReportParser(ICR2WExport chunk)
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
                        case "femaleLength":
                              obj.FemaleLength = rv;
                            break;
                        case "maleLength":
                            obj.MaleLength = rv;
                            break;
                        case "stringId":
                            obj.StringId = rv;
                            break;
                    }
                }
                metaList.Add(obj);
            }

            return metaList;
        }
    }
}