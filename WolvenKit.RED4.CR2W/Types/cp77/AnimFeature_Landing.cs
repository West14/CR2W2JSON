using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Landing : animAnimFeature
	{
		[Ordinal(0)] [RED("type")] public CInt32 Type { get; set; }
		[Ordinal(1)] [RED("impactSpeed")] public CFloat ImpactSpeed { get; set; }

		public AnimFeature_Landing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
