using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_DistanceAbstractBase : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("maxColor")] public CColor MaxColor { get; set; }
		[Ordinal(1)] [RED("minColor")] public CColor MinColor { get; set; }
		[Ordinal(2)] [RED("minDistance")] public CFloat MinDistance { get; set; }
		[Ordinal(3)] [RED("maxDistance")] public CFloat MaxDistance { get; set; }

		public worldDebugColoring_DistanceAbstractBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
