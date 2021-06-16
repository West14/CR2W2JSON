#nullable enable
using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Catel.IoC;
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
                //process subtitles from subtitles map file
                else if (parser.GetType()== typeof(SubtitlesMapParser))
                {
                    //iterate through all SubtitlesMap entries
                    {
                        //define input subtitle file location
                        //define output subtitle file location
                        try 
                        {
                            //cr2w = read subtitle with cr2w reader
                            //var subtitleVCChunks = CR2W.Chunks[0].VirtualChildrenChunks[0];
                            //SubtitlesParser sp = new SubtitlesParser(subtitleVCChunks);
                            //var subtitleJson = new Json
                            //{
                            //    RootType = subtitleVCChunks.REDType,
                            //    Data = sp.GetData()
                            //};
                            //File.WriteAllText(//defined output path, JsonSerializer.Serialize(subtitleJson));
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                    }
                }
            
                var json = new Json
                {
                    RootType = vcc.REDType,
                    Data = parser.GetData()
                };

                File.WriteAllText(output.FullName, JsonSerializer.Serialize(json));
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
                    return new VOLanguageDataMapParser(chunk);
                case "locVoiceoverMap":
                    return new VOMapParser(chunk);
                case "locVoiceoverLengthMap":
                    return new StringIDVariantLengthsReportParser(chunk);
                case "localizationPersistenceSubtitleEntries":
                    return new SubtitlesParser(chunk);
                case "localizationPersistenceSubtitleMap":
                    return new SubtitlesMapParser(chunk);
            }

            return null;
        }
    }
}
