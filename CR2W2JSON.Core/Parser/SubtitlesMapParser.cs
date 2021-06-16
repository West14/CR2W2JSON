﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W;

namespace CR2W2JSON.Core.Parser
{
    public class SubtitlesMapParser : AbstractParser
    {
        public override ISerializable GetData()
        {
            return GetEntriesDictionary(GetSubtitleEntries(Chunk.data.ChildrEditableVariables[0]));
        }

        public void ParseSubtitleFiles(DirectoryInfo input, DirectoryInfo output)
        {
            var entries = GetSubtitleEntries(Chunk.data.ChildrEditableVariables[0]);
            var cr2wReader = new Cp77FileService();
            var subtitleJson = new Json();
            var subtitlesParser = new SubtitlesParser(null);

            foreach (var entry in entries)
            {
                try
                {
                    var subFileName = (string)entry["subtitleFile"];
                    var relPath = subFileName[subFileName.IndexOf(entry["subtitleGroup"])..];
                    var subFile = new FileInfo(Path.Combine(input.FullName, relPath));
                    var subOutFile = new FileInfo(Path.Combine(output.FullName, relPath));
                    var subCr2w = cr2wReader.TryReadCr2WFile(File.OpenRead(subFile.FullName));
                    var vcc = subCr2w.Chunks[0].VirtualChildrenChunks[0];

                    subtitlesParser.SetChunk(vcc);
                    subtitleJson.Data = subtitlesParser.GetData();
                    subtitleJson.RootType = vcc.REDType;

                    Directory.CreateDirectory(subOutFile.DirectoryName);

                    File.WriteAllText(subOutFile.FullName, JsonSerializer.Serialize(subtitleJson));
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        
        private List<Dictionary<string, dynamic>> GetSubtitleEntries(IEditableVariable evar)
        {
            var entryList = new List<Dictionary<string, dynamic>>();

            foreach (var sVariable in evar.ChildrEditableVariables)
            {
                var entry = new Dictionary<string, dynamic>();
                foreach (var editableVariable in sVariable.ChildrEditableVariables)
                {
                    var redValue = editableVariable.REDValue;
                    var redName = editableVariable.REDName;
                    entry.Add(redName, redName == "subtitleGroup" ? redValue : redValue.Replace("[Soft]", ""));
                }
                entryList.Add(entry);
            }

            return entryList;
        }

        public SubtitlesMapParser(ICR2WExport chunk) : base(chunk) {}
    }
}