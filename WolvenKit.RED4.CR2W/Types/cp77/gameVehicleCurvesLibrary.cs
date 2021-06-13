using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVehicleCurvesLibrary : entEntity
	{
		[Ordinal(2)] [RED("curves")] public CArray<rRef<gameVehicleCurveSet>> Curves { get; set; }
		[Ordinal(3)] [RED("commonCurves")] public CArray<rRef<gameVehicleCommonCurveSet>> CommonCurves { get; set; }
		[Ordinal(4)] [RED("bikeCurves")] public CArray<rRef<vehicleBikeCurveSet>> BikeCurves { get; set; }

		public gameVehicleCurvesLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
