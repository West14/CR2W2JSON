using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionDroneMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("moveType")] public CHandle<AIArgumentMapping> MoveType { get; set; }
		[Ordinal(2)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(3)] [RED("movementTarget")] public CHandle<AIArgumentMapping> MovementTarget { get; set; }
		[Ordinal(4)] [RED("toleranceRadius")] public CHandle<AIArgumentMapping> ToleranceRadius { get; set; }
		[Ordinal(5)] [RED("desiredDistanceFromTarget")] public CHandle<AIArgumentMapping> DesiredDistanceFromTarget { get; set; }
		[Ordinal(6)] [RED("strafingTarget")] public CHandle<AIArgumentMapping> StrafingTarget { get; set; }
		[Ordinal(7)] [RED("stopWhenDestinationReached")] public CHandle<AIArgumentMapping> StopWhenDestinationReached { get; set; }
		[Ordinal(8)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }

		public AIbehaviorActionDroneMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
