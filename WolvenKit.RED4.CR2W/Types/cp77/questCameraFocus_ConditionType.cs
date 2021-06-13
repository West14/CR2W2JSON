using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCameraFocus_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)] [RED("timeInterval")] public CFloat TimeInterval { get; set; }
		[Ordinal(2)] [RED("onScreenTest")] public CBool OnScreenTest { get; set; }
		[Ordinal(3)] [RED("useFrustrumCheck")] public CBool UseFrustrumCheck { get; set; }
		[Ordinal(4)] [RED("angleTolerance")] public CFloat AngleTolerance { get; set; }
		[Ordinal(5)] [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(6)] [RED("zoomed")] public CBool Zoomed { get; set; }

		public questCameraFocus_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
