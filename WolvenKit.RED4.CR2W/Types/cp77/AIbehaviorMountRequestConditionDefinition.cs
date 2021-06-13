using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMountRequestConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("testMountRequest")] public CBool TestMountRequest { get; set; }
		[Ordinal(2)] [RED("testUnmountRequest")] public CBool TestUnmountRequest { get; set; }
		[Ordinal(3)] [RED("acceptInstant")] public CBool AcceptInstant { get; set; }
		[Ordinal(4)] [RED("acceptNotInstant")] public CBool AcceptNotInstant { get; set; }

		public AIbehaviorMountRequestConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
