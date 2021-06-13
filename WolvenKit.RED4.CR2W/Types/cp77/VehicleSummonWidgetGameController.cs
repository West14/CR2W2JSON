using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleSummonWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("vehicleNameLabel")] public inkTextWidgetReference VehicleNameLabel { get; set; }
		[Ordinal(10)] [RED("vehicleTypeIcon")] public inkImageWidgetReference VehicleTypeIcon { get; set; }
		[Ordinal(11)] [RED("vehicleManufactorIcon")] public inkImageWidgetReference VehicleManufactorIcon { get; set; }
		[Ordinal(12)] [RED("distanceLabel")] public inkTextWidgetReference DistanceLabel { get; set; }
		[Ordinal(13)] [RED("isWaiting")] public inkTextWidgetReference IsWaiting { get; set; }
		[Ordinal(14)] [RED("unit")] public CEnum<EMeasurementUnit> Unit { get; set; }
		[Ordinal(15)] [RED("unitText")] public inkTextWidgetReference UnitText { get; set; }
		[Ordinal(16)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(17)] [RED("animationCounterProxy")] public CHandle<inkanimProxy> AnimationCounterProxy { get; set; }
		[Ordinal(18)] [RED("optionIntro")] public inkanimPlaybackOptions OptionIntro { get; set; }
		[Ordinal(19)] [RED("optionCounter")] public inkanimPlaybackOptions OptionCounter { get; set; }
		[Ordinal(20)] [RED("vehicleSummonDataDef")] public CHandle<VehicleSummonDataDef> VehicleSummonDataDef { get; set; }
		[Ordinal(21)] [RED("vehicleSummonDataBB")] public CHandle<gameIBlackboard> VehicleSummonDataBB { get; set; }
		[Ordinal(22)] [RED("vehicleSummonStateCallback")] public CUInt32 VehicleSummonStateCallback { get; set; }
		[Ordinal(23)] [RED("vehicleSummonState")] public CUInt32 VehicleSummonState { get; set; }
		[Ordinal(24)] [RED("vehiclePos")] public Vector4 VehiclePos { get; set; }
		[Ordinal(25)] [RED("playerPos")] public Vector4 PlayerPos { get; set; }
		[Ordinal(26)] [RED("distanceVector")] public Vector4 DistanceVector { get; set; }
		[Ordinal(27)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(28)] [RED("distance")] public CInt32 Distance { get; set; }
		[Ordinal(29)] [RED("vehicleID")] public entEntityID VehicleID { get; set; }
		[Ordinal(30)] [RED("vehicleEntity")] public wCHandle<entEntity> VehicleEntity { get; set; }
		[Ordinal(31)] [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }
		[Ordinal(32)] [RED("vehicleRecord")] public CHandle<gamedataVehicle_Record> VehicleRecord { get; set; }
		[Ordinal(33)] [RED("textParams")] public CHandle<textTextParameterSet> TextParams { get; set; }
		[Ordinal(34)] [RED("iconRecord")] public CHandle<gamedataUIIcon_Record> IconRecord { get; set; }

		public VehicleSummonWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
