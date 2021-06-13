using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExtractMountParentStubPositionTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
		[Ordinal(2)] [RED("position")] public CHandle<AIArgumentMapping> Position { get; set; }

		public AIbehaviorExtractMountParentStubPositionTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
