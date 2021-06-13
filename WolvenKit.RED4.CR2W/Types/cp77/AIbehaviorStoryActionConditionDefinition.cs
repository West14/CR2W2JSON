using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStoryActionConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("action")] public CEnum<AIbehaviorStoryActionType> Action { get; set; }

		public AIbehaviorStoryActionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
