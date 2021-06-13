using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using CsvHelper;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Common.Model
{
    public class Cr2wResourceManager
    {
        #region Fields

        public static readonly string pathashespath =
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Config",
                "pathhashes.csv");

        private static readonly string custompathashespath =
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Config",
                "custompathhashes.csv");

        private static Cr2wResourceManager resourceManager;

        #endregion Fields

        #region Constructors

        public Cr2wResourceManager()
        {
            HashdumpDict = new Dictionary<string, ulong>();
            CHashdumpDict = new Dictionary<string, ulong>();

            if (File.Exists(pathashespath))
            {
                using (StreamReader reader = File.OpenText(pathashespath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    HashdumpDict = csv.GetRecords<HashDump>().ToDictionary(_ => _.Path, _ => _.HashInt);
                }
            }

            if (File.Exists(custompathashespath))
            {
                using (StreamReader reader = File.OpenText(custompathashespath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    CHashdumpDict = csv.GetRecords<HashDump>().ToDictionary(_ => _.Path, _ => _.HashInt);
                }
            }
        }

        #endregion Constructors

        #region Properties

        public Dictionary<string, ulong> CHashdumpDict { get; }
        public Dictionary<string, ulong> HashdumpDict { get; }

        #endregion Properties

        #region Methods

        public static Cr2wResourceManager Get()
        {
            if (resourceManager == null)
            {
                resourceManager = new Cr2wResourceManager();
            }
            return resourceManager;
        }

        public ulong RegisterAndWriteCustomPath(string path)
        {
            var hash = RegisterCustomPath(path);
            Write();
            return hash;
        }

        public void RegisterAndWriteCustomPaths(List<string> paths)
        {
            foreach (var path in paths)
            {
                RegisterCustomPath(path);
            }
            Write();
        }

        public void RegisterAndWriteVanillaPaths(List<string> paths)
        {
            foreach (var path in paths)
            {
                RegisterVanillaPath(path);
            }
            Write();
        }

        public ulong RegisterCustomPath(string path)
        {
            var hashint = FNV1A64HashAlgorithm.HashString(path);
            if (!CHashdumpDict.ContainsKey(path) && !HashdumpDict.ContainsKey(path))
                CHashdumpDict.Add(path, hashint);
            return hashint;
        }

        public ulong RegisterVanillaPath(string path)
        {
            var hashint = FNV1A64HashAlgorithm.HashString(path);
            if (!HashdumpDict.ContainsKey(path))
                HashdumpDict.Add(path, hashint);
            return hashint;
        }

        public void Write()
        {
            using (var writer = new StreamWriter(custompathashespath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(CHashdumpDict.Select(_ => new HashDump { Path = _.Key, HashInt = _.Value }));
            }
        }

        public void WriteVanilla()
        {
            using (var writer = new StreamWriter(pathashespath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(HashdumpDict.Select(_ => new HashDump { Path = _.Key, HashInt = _.Value }));
            }
        }

        #endregion Methods
    }
}
