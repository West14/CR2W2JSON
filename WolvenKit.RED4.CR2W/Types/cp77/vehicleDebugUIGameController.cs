using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDebugUIGameController : gameuiBaseVehicleHUDGameController
	{
		[Ordinal(10)] [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }
		[Ordinal(11)] [RED("vehicleBBStateConectionId")] public CUInt32 VehicleBBStateConectionId { get; set; }
		[Ordinal(12)] [RED("mountBBConnectionId")] public CUInt32 MountBBConnectionId { get; set; }
		[Ordinal(13)] [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(14)] [RED("gearBBConnectionId")] public CUInt32 GearBBConnectionId { get; set; }
		[Ordinal(15)] [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(16)] [RED("rpmMaxBBConnectionId")] public CUInt32 RpmMaxBBConnectionId { get; set; }
		[Ordinal(17)] [RED("radioStateBBConnectionId")] public CUInt32 RadioStateBBConnectionId { get; set; }
		[Ordinal(18)] [RED("radioNameBBConnectionId")] public CUInt32 RadioNameBBConnectionId { get; set; }
		[Ordinal(19)] [RED("radioState")] public CBool RadioState { get; set; }
		[Ordinal(20)] [RED("radioName")] public CName RadioName { get; set; }
		[Ordinal(21)] [RED("radioStateWidget")] public wCHandle<inkTextWidget> RadioStateWidget { get; set; }
		[Ordinal(22)] [RED("radioNameWidget")] public wCHandle<inkTextWidget> RadioNameWidget { get; set; }
		[Ordinal(23)] [RED("autopilotOnId")] public CUInt32 AutopilotOnId { get; set; }
		[Ordinal(24)] [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(25)] [RED("speedTextWidget")] public wCHandle<inkTextWidget> SpeedTextWidget { get; set; }
		[Ordinal(26)] [RED("gearTextWidget")] public wCHandle<inkTextWidget> GearTextWidget { get; set; }
		[Ordinal(27)] [RED("rpmValueWidget")] public wCHandle<inkTextWidget> RpmValueWidget { get; set; }
		[Ordinal(28)] [RED("rpmGaugeForegroundWidget")] public wCHandle<inkRectangleWidget> RpmGaugeForegroundWidget { get; set; }
		[Ordinal(29)] [RED("rpmGaugeMaxSize")] public Vector2 RpmGaugeMaxSize { get; set; }
		[Ordinal(30)] [RED("rpmMinValue")] public CFloat RpmMinValue { get; set; }
		[Ordinal(31)] [RED("rpmMaxValue")] public CFloat RpmMaxValue { get; set; }
		[Ordinal(32)] [RED("rpmMaxValueInitialized")] public CBool RpmMaxValueInitialized { get; set; }
		[Ordinal(33)] [RED("autopilotTextWidget")] public wCHandle<inkTextWidget> AutopilotTextWidget { get; set; }
		[Ordinal(34)] [RED("isInAutoPilot")] public CBool IsInAutoPilot { get; set; }
		[Ordinal(35)] [RED("useDebugUI")] public CBool UseDebugUI { get; set; }

		public vehicleDebugUIGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
