using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMountEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
		[Ordinal(1)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(2)] [RED("isInstant")] public CHandle<AIArgumentMapping> IsInstant { get; set; }
		[Ordinal(3)] [RED("behaviorCallbackName")] public CName BehaviorCallbackName { get; set; }

		public AIbehaviorMountEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
