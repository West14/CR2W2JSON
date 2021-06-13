using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNodeStatusDebuggerCommandEntry : CVariable
	{
		[Ordinal(0)] [RED("nodeId")] public CGUID NodeId { get; set; }
		[Ordinal(1)] [RED("status")] public CEnum<AIbehaviorDebugNodeStatus> Status { get; set; }
		[Ordinal(2)] [RED("generation")] public CUInt32 Generation { get; set; }
		[Ordinal(3)] [RED("failure")] public CHandle<gamedebugFailure> Failure { get; set; }

		public AIbehaviorNodeStatusDebuggerCommandEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
