using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindAlertedWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("usedTokens")] public CHandle<AIArgumentMapping> UsedTokens { get; set; }
		[Ordinal(2)] [RED("spots")] public CHandle<AIArgumentMapping> Spots { get; set; }
		[Ordinal(3)] [RED("radius")] public CHandle<AIArgumentMapping> Radius { get; set; }
		[Ordinal(4)] [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }

		public AIbehaviorFindAlertedWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
