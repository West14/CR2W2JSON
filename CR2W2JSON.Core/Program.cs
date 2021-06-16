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
    internal class Json
    {
        [JsonInclude] [JsonPropertyName("RootType")] public string RootType;
        [JsonInclude] [JsonPropertyName("Data")] public object Data;
    }

    internal static class Program
    {
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Reflection.CustomAttributeNamedParameter[]")]
        private static int Main(string[] args)
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

                    if (parser.GetType() == typeof(SubtitlesMapParser))
                    {
                        if (input.DirectoryName == output.DirectoryName)
                        {
                            Console.WriteLine("To convert subtitles the output directory must be " +
                                              "different from the input directory.");
                            Environment.Exit(2);
                        }
                        
                        ((SubtitlesMapParser)parser).
                            ParseSubtitleFiles(input.Directory, output.Directory);
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
        
        private static AbstractParser GetParserByType(string type, ICR2WExport chunk)
        {
            return type switch
            {
                "audioAudioEventArray" => new AudioEventArrayParser(chunk),
                "localizationPersistenceOnScreenEntries" => new OnScreenParser(chunk),
                "localizationPersistenceLocDataMap" => new LocDataMapAbstractParser(chunk),
                "locVoLanguageDataMap" => new VoLanguageDataMapParser(chunk),
                "locVoiceoverMap" => new VoMapParser(chunk),
                "locVoiceoverLengthMap" => new StringIdVariantLengthsReportParser(chunk),
                "localizationPersistenceSubtitleEntries" => new SubtitlesParser(chunk),
                "localizationPersistenceSubtitleMap" => new SubtitlesMapParser(chunk),
                _ => null
            };
        }
    }
}
