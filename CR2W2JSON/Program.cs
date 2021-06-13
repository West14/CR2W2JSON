#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Catel.IoC;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace CR2W2JSON
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
            }

            return null;
        }
    }
}
