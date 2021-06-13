using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("commandName")] public CHandle<AIArgumentMapping> CommandName { get; set; }
		[Ordinal(2)] [RED("useInheritance")] public CBool UseInheritance { get; set; }
		[Ordinal(3)] [RED("isWaiting")] public CBool IsWaiting { get; set; }
		[Ordinal(4)] [RED("isExecuting")] public CBool IsExecuting { get; set; }
		[Ordinal(5)] [RED("commandOut")] public CHandle<AIArgumentMapping> CommandOut { get; set; }

		public AIbehaviorCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
