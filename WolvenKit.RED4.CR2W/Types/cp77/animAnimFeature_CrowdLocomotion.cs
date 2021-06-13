using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_CrowdLocomotion : animAnimFeature
	{
		[Ordinal(0)] [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(1)] [RED("slopeAngle")] public CFloat SlopeAngle { get; set; }
		[Ordinal(2)] [RED("isCrowd")] public CBool IsCrowd { get; set; }

		public animAnimFeature_CrowdLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
