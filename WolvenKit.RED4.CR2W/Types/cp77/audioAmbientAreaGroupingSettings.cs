using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaGroupingSettings : CVariable
	{
		[Ordinal(0)] [RED("GroupCountTag")] public CName GroupCountTag { get; set; }
		[Ordinal(1)] [RED("GroupCountRtpc")] public CName GroupCountRtpc { get; set; }
		[Ordinal(2)] [RED("GroupAvgDistanceRtpc")] public CName GroupAvgDistanceRtpc { get; set; }
		[Ordinal(3)] [RED("groupingVariant")] public CEnum<audioAmbientGroupingVariant> GroupingVariant { get; set; }
		[Ordinal(4)] [RED("MinDistance")] public CFloat MinDistance { get; set; }
		[Ordinal(5)] [RED("MaxDistance")] public CFloat MaxDistance { get; set; }

		public audioAmbientAreaGroupingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
