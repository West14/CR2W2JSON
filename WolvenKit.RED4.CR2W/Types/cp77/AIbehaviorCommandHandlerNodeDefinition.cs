using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandHandlerNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("commandName")] public CName CommandName { get; set; }
		[Ordinal(2)] [RED("useInheritance")] public CBool UseInheritance { get; set; }
		[Ordinal(3)] [RED("contexts")] public CArray<CEnum<AICommandContextsType>> Contexts { get; set; }
		[Ordinal(4)] [RED("commandOut")] public CHandle<AIArgumentMapping> CommandOut { get; set; }
		[Ordinal(5)] [RED("runningSignal")] public CName RunningSignal { get; set; }
		[Ordinal(6)] [RED("waitForCommand")] public CBool WaitForCommand { get; set; }
		[Ordinal(7)] [RED("retryIfCommandEnqueued")] public CBool RetryIfCommandEnqueued { get; set; }
		[Ordinal(8)] [RED("resultIfNoCommand")] public CEnum<AIbehaviorCompletionStatus> ResultIfNoCommand { get; set; }
		[Ordinal(9)] [RED("resultIfChildFailed")] public CEnum<AIbehaviorCompletionStatus> ResultIfChildFailed { get; set; }

		public AIbehaviorCommandHandlerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
