using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtPose360 : animAnimNode_Base
	{
		[Ordinal(11)] [RED("speedInDegreesPerSecond")] public CFloat SpeedInDegreesPerSecond { get; set; }
		[Ordinal(12)] [RED("angleOffsetNode")] public animFloatLink AngleOffsetNode { get; set; }
		[Ordinal(13)] [RED("targetAngleOffsetNode")] public animFloatLink TargetAngleOffsetNode { get; set; }
		[Ordinal(14)] [RED("animation")] public CName Animation { get; set; }
		[Ordinal(15)] [RED("durationCut")] public CFloat DurationCut { get; set; }

		public animAnimNode_LookAtPose360(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
