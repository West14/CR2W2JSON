using System.Collections.Generic;
using System.Runtime.Serialization;
using WolvenKit.Common.Model.Cr2w;

namespace CR2W2JSON.Core.Parser
{
    public abstract class AbstractParser
    {
        protected readonly ICR2WExport Chunk;

        protected AbstractParser(ICR2WExport chunk)
        {
            Chunk = chunk;
        }

        public abstract ISerializable GetData();

        protected Dictionary<string, List<Dictionary<string, dynamic>>> GetEntriesDictionary(List<Dictionary<string, dynamic>> entryList) => 
            new() {{"entries", entryList}};
    }
}