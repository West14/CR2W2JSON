using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(2)] [RED("returnPosition")] public CHandle<AIArgumentMapping> ReturnPosition { get; set; }
		[Ordinal(3)] [RED("returnPositionVector")] public CHandle<AIArgumentMapping> ReturnPositionVector { get; set; }
		[Ordinal(4)] [RED("workspotExitTangent")] public CHandle<AIArgumentMapping> WorkspotExitTangent { get; set; }
		[Ordinal(5)] [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }
		[Ordinal(6)] [RED("overrideExit")] public CHandle<AIArgumentMapping> OverrideExit { get; set; }

		public AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
