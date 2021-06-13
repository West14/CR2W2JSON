using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCommunityEntryInitialState : CVariable
	{
		[Ordinal(0)] [RED("entryName")] public CName EntryName { get; set; }
		[Ordinal(1)] [RED("initialPhaseName")] public CName InitialPhaseName { get; set; }
		[Ordinal(2)] [RED("entryActiveOnStart")] public CBool EntryActiveOnStart { get; set; }

		public worldCommunityEntryInitialState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
