using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEventWithTagConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(2)] [RED("consumeEvent")] public CBool ConsumeEvent { get; set; }

		public AIbehaviorEventWithTagConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
