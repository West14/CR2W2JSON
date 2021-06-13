using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerTrail : IParticleDrawer
	{
		[Ordinal(1)] [RED("texturesPerUnit")] public CFloat TexturesPerUnit { get; set; }
		[Ordinal(2)] [RED("dynamicTexCoords")] public CBool DynamicTexCoords { get; set; }
		[Ordinal(3)] [RED("minSegmentsPer360Degrees")] public CInt32 MinSegmentsPer360Degrees { get; set; }
		[Ordinal(4)] [RED("ribbonize")] public CBool Ribbonize { get; set; }
		[Ordinal(5)] [RED("ribbonTesselationDelta")] public CFloat RibbonTesselationDelta { get; set; }

		public CParticleDrawerTrail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
