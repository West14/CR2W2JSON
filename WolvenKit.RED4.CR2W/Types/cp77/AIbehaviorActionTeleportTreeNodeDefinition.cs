using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionTeleportTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("destinationPoint")] public CHandle<AIArgumentMapping> DestinationPoint { get; set; }
		[Ordinal(2)] [RED("doNavTest")] public CHandle<AIArgumentMapping> DoNavTest { get; set; }
		[Ordinal(3)] [RED("rotation")] public CHandle<AIArgumentMapping> Rotation { get; set; }

		public AIbehaviorActionTeleportTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
