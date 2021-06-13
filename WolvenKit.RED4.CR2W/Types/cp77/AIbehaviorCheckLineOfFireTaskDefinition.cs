using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCheckLineOfFireTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("slotName")] public CHandle<AIArgumentMapping> SlotName { get; set; }
		[Ordinal(2)] [RED("attachmentName")] public CHandle<AIArgumentMapping> AttachmentName { get; set; }
		[Ordinal(3)] [RED("spread")] public CHandle<AIArgumentMapping> Spread { get; set; }
		[Ordinal(4)] [RED("maxRange")] public CHandle<AIArgumentMapping> MaxRange { get; set; }

		public AIbehaviorCheckLineOfFireTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
