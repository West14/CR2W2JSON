using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AnimDatabase : animAnimNode_SkPhaseWithDurationAnim
	{
		[Ordinal(32)] [RED("animDataBase")] public animAnimDatabaseCollectionEntry AnimDataBase { get; set; }
		[Ordinal(33)] [RED("inputLinks")] public CArray<animIntLink> InputLinks { get; set; }

		public animAnimNode_AnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
