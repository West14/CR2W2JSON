using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConditionDefinition : AIbehaviorBehaviorComponentDefinition
	{
		[Ordinal(0)] [RED("isInverted")] public CBool IsInverted { get; set; }

		public AIbehaviorConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
