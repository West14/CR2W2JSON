using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AINavigationSystemQuery : CVariable
	{
		[Ordinal(0)] [RED("source")] public AIPositionSpec Source { get; set; }
		[Ordinal(1)] [RED("target")] public AIPositionSpec Target { get; set; }
		[Ordinal(2)] [RED("allowedTags")] public CArray<CName> AllowedTags { get; set; }
		[Ordinal(3)] [RED("blockedTags")] public CArray<CName> BlockedTags { get; set; }
		[Ordinal(4)] [RED("minDesiredDistance")] public CFloat MinDesiredDistance { get; set; }
		[Ordinal(5)] [RED("maxDesiredDistance")] public CFloat MaxDesiredDistance { get; set; }
		[Ordinal(6)] [RED("useFollowSlots")] public CBool UseFollowSlots { get; set; }
		[Ordinal(7)] [RED("usePredictionTime")] public CBool UsePredictionTime { get; set; }

		public AINavigationSystemQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
