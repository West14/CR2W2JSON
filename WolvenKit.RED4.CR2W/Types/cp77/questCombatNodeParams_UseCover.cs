using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_UseCover : questCombatNodeParams
	{
		[Ordinal(0)] [RED("cover")] public NodeRef Cover { get; set; }
		[Ordinal(1)] [RED("oneTimeSelection")] public CBool OneTimeSelection { get; set; }
		[Ordinal(2)] [RED("forceStance")] public CArray<CEnum<AICoverExposureMethod>> ForceStance { get; set; }
		[Ordinal(3)] [RED("forcedEntryAnimation")] public CName ForcedEntryAnimation { get; set; }
		[Ordinal(4)] [RED("immediately")] public CBool Immediately { get; set; }

		public questCombatNodeParams_UseCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
