using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCommunitySpawnSetNameToID : CVariable
	{
		[Ordinal(0)] [RED("entries")] public CArray<gameCommunitySpawnSetNameToIDEntry> Entries { get; set; }

		public gameCommunitySpawnSetNameToID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
