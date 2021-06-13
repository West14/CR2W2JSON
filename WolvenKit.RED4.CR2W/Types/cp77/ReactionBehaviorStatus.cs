using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionBehaviorStatus : redEvent
	{
		[Ordinal(0)] [RED("status")] public CEnum<AIbehaviorUpdateOutcome> Status { get; set; }
		[Ordinal(1)] [RED("reactionData")] public CHandle<AIReactionData> ReactionData { get; set; }

		public ReactionBehaviorStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
