using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communitySquadInitializer : communitySpawnInitializer
	{
		[Ordinal(0)] [RED("entries")] public CArray<communitySquadInitializerEntry> Entries { get; set; }

		public communitySquadInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
