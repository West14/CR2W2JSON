using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendSLightFlickering : CVariable
	{
		[Ordinal(0)] [RED("positionOffset")] public CFloat PositionOffset { get; set; }
		[Ordinal(1)] [RED("flickerStrength")] public CFloat FlickerStrength { get; set; }
		[Ordinal(2)] [RED("flickerPeriod")] public CFloat FlickerPeriod { get; set; }

		public rendSLightFlickering(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
