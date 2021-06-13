using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountRequestCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("testMountRequest")] public CBool TestMountRequest { get; set; }
		[Ordinal(1)] [RED("testUnmountRequest")] public CBool TestUnmountRequest { get; set; }
		[Ordinal(2)] [RED("acceptInstant")] public CBool AcceptInstant { get; set; }
		[Ordinal(3)] [RED("acceptNotInstant")] public CBool AcceptNotInstant { get; set; }

		public MountRequestCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
