using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_EyesHeadWithoutSuppress : animLookAtPreset
	{
		[Ordinal(0)] [RED("headMobility")] public CFloat HeadMobility { get; set; }
		[Ordinal(1)] [RED("softLimitAngle")] public CFloat SoftLimitAngle { get; set; }

		public animLookAtPreset_EyesHeadWithoutSuppress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
