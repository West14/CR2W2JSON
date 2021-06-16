#nullable enable
using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Catel.IoC;
using CR2W2JSON.Core.Parser;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W;

namespace CR2W2JSON.Core
{
    class Json
    {
        [JsonInclude]
        [JsonPropertyName("RootType")]
        public string RootType;

        [JsonInclude]
        [JsonPropertyName("Data")]
        public object Data;
    }
    
    class Program
    {
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Reflection.CustomAttributeNamedParameter[]")]
        static int Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new Argument<FileInfo>("input", "CR2W file"),
                new Argument<FileInfo>("output", "JSON file")
            };
            
            var locator = ServiceLocator.Default;
            locator.RegisterType<ILoggerService, LoggerService>();

            rootCommand.Handler = CommandHandler.Create<FileInfo, FileInfo>((input, output) =>
            {
                try
                {
                    var s = new Cp77FileService();
                    var CR2W = s.TryReadCr2WFile(
                        File.OpenRead(input.FullName)
                    );

                    var vcc = CR2W.Chunks[0].VirtualChildrenChunks[0];

                    var parser = GetParserByType(vcc.REDType, vcc);
                    if (parser == null)
                    {
                        Console.WriteLine("Unknown REDType: " + vcc.REDType);
                        Environment.Exit(1);
                    }

                    var json = new Json
                    {
                        RootType = vcc.REDType,
                        Data = parser.GetData()
                    };

                    //process subtitles from subtitles map file
                    if (parser.GetType() == typeof(SubtitlesMapParser))
                    {
                        //iterate through all SubtitlesMap entries
                        foreach (var entrs in ((SubtitlesMapParser)parser).GetEntries())
                        {
                            //define input subtitle file location
                            //define output subtitle file location
                            string sbtlRelPath = entrs.SubtitleFile.Substring(entrs.SubtitleFile.IndexOf(entrs.SubtitleGroup));
                            FileInfo sbtlInPath = new FileInfo(input.DirectoryName + "\\" + sbtlRelPath);
                            FileInfo sbtlOutPath = new FileInfo(output.DirectoryName + "\\" + sbtlRelPath);
                            try
                            {
                                CR2W = s.TryReadCr2WFile(File.OpenRead(sbtlInPath.FullName));
                                var subtitleVCChunks = CR2W.Chunks[0].VirtualChildrenChunks[0];
                                SubtitlesParser sp = new SubtitlesParser(subtitleVCChunks);
                                var subtitleJson = new Json
                                {
                                    RootType = subtitleVCChunks.REDType,
                                    Data = sp.GetData()
                                };

                                if (!Directory.Exists(sbtlOutPath.DirectoryName))
                                {
                                    Directory.CreateDirectory(sbtlOutPath.DirectoryName);
                                }
                                File.WriteAllText(sbtlOutPath.FullName, JsonSerializer.Serialize(subtitleJson));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                    }

                    File.WriteAllText(output.FullName, JsonSerializer.Serialize(json));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            });

            return rootCommand.InvokeAsync(args).Result;
    }
        
        private static IParser? GetParserByType(string type, ICR2WExport chunk)
        {
            switch (type)
            {
                case "audioAudioEventArray":
                    return new AudioEventArrayParser(chunk);
                case "localizationPersistenceOnScreenEntries":
                    return new OnScreenParser(chunk);
                case "localizationPersistenceLocDataMap":
                    return new LocDataMapParser(chunk);
                case "locVoLanguageDataMap":
                    return new VoLanguageDataMapParser(chunk);
                case "locVoiceoverMap":
                    return new VoMapParser(chunk);
                case "locVoiceoverLengthMap":
                    return new StringIdVariantLengthsReportParser(chunk);
                case "localizationPersistenceSubtitleEntries":
                    return new SubtitlesParser(chunk);
                case "localizationPersistenceSubtitleMap":
                    return new SubtitlesMapParser(chunk);
            }

            return null;
        }
    }
}
