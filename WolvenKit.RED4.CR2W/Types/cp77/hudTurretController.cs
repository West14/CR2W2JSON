using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudTurretController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("Date")] public inkTextWidgetReference Date { get; set; }
		[Ordinal(10)] [RED("Timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(11)] [RED("CameraID")] public inkTextWidgetReference CameraID { get; set; }
		[Ordinal(12)] [RED("healthStatus")] public inkTextWidgetReference HealthStatus { get; set; }
		[Ordinal(13)] [RED("MessageText")] public inkTextWidgetReference MessageText { get; set; }
		[Ordinal(14)] [RED("pitchFluff")] public inkTextWidgetReference PitchFluff { get; set; }
		[Ordinal(15)] [RED("yawFluff")] public inkTextWidgetReference YawFluff { get; set; }
		[Ordinal(16)] [RED("leftPart")] public inkWidgetReference LeftPart { get; set; }
		[Ordinal(17)] [RED("rightPart")] public inkWidgetReference RightPart { get; set; }
		[Ordinal(18)] [RED("offsetLeft")] public CFloat OffsetLeft { get; set; }
		[Ordinal(19)] [RED("offsetRight")] public CFloat OffsetRight { get; set; }
		[Ordinal(20)] [RED("currentTime")] public GameTime CurrentTime { get; set; }
		[Ordinal(21)] [RED("bbPlayerStats")] public CHandle<gameIBlackboard> BbPlayerStats { get; set; }
		[Ordinal(22)] [RED("bbPlayerEventId")] public CUInt32 BbPlayerEventId { get; set; }
		[Ordinal(23)] [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(24)] [RED("previousHealth")] public CInt32 PreviousHealth { get; set; }
		[Ordinal(25)] [RED("maximumHealth")] public CInt32 MaximumHealth { get; set; }
		[Ordinal(26)] [RED("playerObject")] public wCHandle<gameObject> PlayerObject { get; set; }
		[Ordinal(27)] [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(28)] [RED("optionIntro")] public inkanimPlaybackOptions OptionIntro { get; set; }
		[Ordinal(29)] [RED("optionMalfunction")] public inkanimPlaybackOptions OptionMalfunction { get; set; }
		[Ordinal(30)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(31)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public hudTurretController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
