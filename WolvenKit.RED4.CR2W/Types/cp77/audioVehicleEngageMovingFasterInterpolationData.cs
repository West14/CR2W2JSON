using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleEngageMovingFasterInterpolationData : CVariable
	{
		[Ordinal(0)] [RED("enterCurveType")] public CEnum<audioESoundCurveType> EnterCurveType { get; set; }
		[Ordinal(1)] [RED("enterCurveTime")] public CFloat EnterCurveTime { get; set; }
		[Ordinal(2)] [RED("exitCurveType")] public CEnum<audioESoundCurveType> ExitCurveType { get; set; }
		[Ordinal(3)] [RED("exitCurveTime")] public CFloat ExitCurveTime { get; set; }

		public audioVehicleEngageMovingFasterInterpolationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
