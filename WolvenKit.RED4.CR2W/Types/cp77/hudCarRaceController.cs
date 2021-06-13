using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudCarRaceController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("Countdown")] public inkCanvasWidgetReference Countdown { get; set; }
		[Ordinal(10)] [RED("PositionCounter")] public inkCanvasWidgetReference PositionCounter { get; set; }
		[Ordinal(11)] [RED("RacePosition")] public inkTextWidgetReference RacePosition { get; set; }
		[Ordinal(12)] [RED("RaceTime")] public inkTextWidgetReference RaceTime { get; set; }
		[Ordinal(13)] [RED("RaceCheckpoint")] public inkTextWidgetReference RaceCheckpoint { get; set; }
		[Ordinal(14)] [RED("maxPosition")] public CInt32 MaxPosition { get; set; }
		[Ordinal(15)] [RED("maxCheckpoint")] public CInt32 MaxCheckpoint { get; set; }
		[Ordinal(16)] [RED("playerPosition")] public CInt32 PlayerPosition { get; set; }
		[Ordinal(17)] [RED("minute")] public CInt32 Minute { get; set; }
		[Ordinal(18)] [RED("activeVehicleUIBlackboard")] public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard { get; set; }
		[Ordinal(19)] [RED("activeVehicle")] public wCHandle<vehicleBaseObject> ActiveVehicle { get; set; }
		[Ordinal(20)] [RED("raceStartEngineTime")] public EngineTime RaceStartEngineTime { get; set; }
		[Ordinal(21)] [RED("factCallbackID")] public CUInt32 FactCallbackID { get; set; }

		public hudCarRaceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
