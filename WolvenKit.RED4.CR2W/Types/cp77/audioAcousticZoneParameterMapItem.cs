using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAcousticZoneParameterMapItem : audioAudioMetadata
	{
		[Ordinal(1)] [RED("param")] public CName Param { get; set; }
		[Ordinal(2)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(3)] [RED("enterCurveTime")] public CFloat EnterCurveTime { get; set; }
		[Ordinal(4)] [RED("exitCurveTime")] public CFloat ExitCurveTime { get; set; }

		public audioAcousticZoneParameterMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
