using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentHiddenTrianglesRemovalParams : CVariable
	{
		[Ordinal(0)] [RED("garmentBorderThreshold")] public CFloat GarmentBorderThreshold { get; set; }
		[Ordinal(1)] [RED("removeHiddenTriangles")] public CBool RemoveHiddenTriangles { get; set; }
		[Ordinal(2)] [RED("removeHiddenTrianglesRasterization")] public CBool RemoveHiddenTrianglesRasterization { get; set; }
		[Ordinal(3)] [RED("rayLengthInCM")] public CFloat RayLengthInCM { get; set; }
		[Ordinal(4)] [RED("rayLengthMorphOffsetFactor")] public CFloat RayLengthMorphOffsetFactor { get; set; }

		public garmentHiddenTrianglesRemovalParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
