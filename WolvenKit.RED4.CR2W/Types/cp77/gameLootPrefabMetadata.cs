using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootPrefabMetadata : worldPrefabMetadata
	{
		[Ordinal(0)] [RED("lootTableTDBIDs")] public CArray<TweakDBID> LootTableTDBIDs { get; set; }
		[Ordinal(1)] [RED("ignoreParentPrefabs")] public CBool IgnoreParentPrefabs { get; set; }
		[Ordinal(2)] [RED("contentAssignment")] public TweakDBID ContentAssignment { get; set; }

		public gameLootPrefabMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
