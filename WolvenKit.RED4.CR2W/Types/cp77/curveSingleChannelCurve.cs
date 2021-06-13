using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class curveSingleChannelCurve : CVariable
	{
		[Ordinal(0)] [RED("interpolationType")] public CEnum<curveEInterpolationType> InterpolationType { get; set; }
		[Ordinal(1)] [RED("linkType")] public CEnum<curveESegmentsLinkType> LinkType { get; set; }
		[Ordinal(2)] [RED("data")] public DataBuffer Data { get; set; }

		public curveSingleChannelCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
