using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class analogSpeedometerLogicController : IVehicleModuleController
	{
		[Ordinal(1)] [RED("analogSpeedNeedleWidget")] public inkWidgetReference AnalogSpeedNeedleWidget { get; set; }
		[Ordinal(2)] [RED("analogSpeedNeedleMinRotation")] public CFloat AnalogSpeedNeedleMinRotation { get; set; }
		[Ordinal(3)] [RED("analogSpeedNeedleMaxRotation")] public CFloat AnalogSpeedNeedleMaxRotation { get; set; }
		[Ordinal(4)] [RED("analogSpeedNeedleMaxValue")] public CFloat AnalogSpeedNeedleMaxValue { get; set; }
		[Ordinal(5)] [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(6)] [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }
		[Ordinal(7)] [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }

		public analogSpeedometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
