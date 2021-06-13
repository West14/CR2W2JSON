using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public class GameFileTreeNode
    {
        #region Constructors

        public GameFileTreeNode()
        {
            Directories = new Dictionary<string, GameFileTreeNode>();
            Files = new Dictionary<string, List<IGameFile>>();
            Name = "";
        }

        public GameFileTreeNode(EArchiveType bundleType)
        {
            Directories = new Dictionary<string, GameFileTreeNode>();
            Files = new Dictionary<string, List<IGameFile>>();
            Name = "";
        }

        #endregion Constructors

        #region Properties

        public Dictionary<string, GameFileTreeNode> Directories { get; set; }

        public string Extension => nameof(ECustomImageKeys.ClosedDirImageKey);

        public Dictionary<string, List<IGameFile>> Files { get; set; }

        public string FullPath
        {
            get
            {
                var path = "";
                var current = this;
                while (true)
                {
                    path = Path.Combine(current.Name, path);
                    current = current.Parent;
                    if (current == null)
                        break;
                }
                return path ?? "";
            }
        }

        public string Name { get; set; }

        public GameFileTreeNode Parent { get; set; }

        public List<GameFileTreeNode> SubDirectories => Directories.Values.ToList();

        public EArchiveType Type
        {
            get
            {
                // Getting the type of the archive by its path
                string[] bundlenodenames = FullPath.Split(Path.DirectorySeparatorChar);
                string bundlename;
                //At app startup there will be no Root prefixed, but after it will
                if (bundlenodenames.First() == "Root")
                {
                    bundlename = bundlenodenames.Skip(1).First();
                }
                else
                {
                    bundlename = bundlenodenames.First();
                }

                if (String.IsNullOrEmpty(bundlename) || bundlename.ToUpper() == "ROOT" || bundlename.ToUpper() == "DEPOT")
                    bundlename = EArchiveType.ANY.ToString();

                return (EArchiveType)Enum.Parse(typeof(EArchiveType), bundlename);
            }
        }

        #endregion Properties

        #region Methods

        public List<AssetBrowserData> ToAssetBrowserData()
        {
            var ret = new List<AssetBrowserData>();
            ret.Add(new AssetBrowserData()
            {
                Name = "..",
                Extension = nameof(ECustomImageKeys.OpenDirImageKey),
                Type = EntryType.MoveUP,
                This = this,
                Parent = this.Parent
            });
            ret.AddRange(Directories.Select(d => new AssetBrowserData()
            {
                Name = d.Key,
                Size = d.Value.Directories.Count + " directories, " + d.Value.Files.Count + " files",
                Parent = this.Parent,
                Children = d.Value,
                Extension = nameof(ECustomImageKeys.ClosedDirImageKey),
                This = this,
                Type = EntryType.Directory
            }));

            ret.AddRange(Files.Select(f => new AssetBrowserData()
            {
                Name = f.Key,
                Size = f.Value[0].Size + " bytes",
                This = this,
                Extension = Path.GetExtension(f.Key),
                Type = EntryType.File,
                Parent = this.Parent
            }));

            return ret;
        }

        #endregion Methods
    }
}
