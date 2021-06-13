using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class healthbarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("bbPlayerStats")] public CHandle<gameIBlackboard> BbPlayerStats { get; set; }
		[Ordinal(10)] [RED("bbPlayerEventId")] public CUInt32 BbPlayerEventId { get; set; }
		[Ordinal(11)] [RED("bbRightWeaponInfo")] public CHandle<gameIBlackboard> BbRightWeaponInfo { get; set; }
		[Ordinal(12)] [RED("bbRightWeaponEventId")] public CUInt32 BbRightWeaponEventId { get; set; }
		[Ordinal(13)] [RED("bbLeftWeaponInfo")] public CHandle<gameIBlackboard> BbLeftWeaponInfo { get; set; }
		[Ordinal(14)] [RED("bbLeftWeaponEventId")] public CUInt32 BbLeftWeaponEventId { get; set; }
		[Ordinal(15)] [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(16)] [RED("visionStateBlackboardId")] public CUInt32 VisionStateBlackboardId { get; set; }
		[Ordinal(17)] [RED("combatModeBlackboardId")] public CUInt32 CombatModeBlackboardId { get; set; }
		[Ordinal(18)] [RED("bbQuickhacksMemeoryEventId")] public CUInt32 BbQuickhacksMemeoryEventId { get; set; }
		[Ordinal(19)] [RED("healthPath")] public inkWidgetPath HealthPath { get; set; }
		[Ordinal(20)] [RED("healthBarPath")] public inkWidgetPath HealthBarPath { get; set; }
		[Ordinal(21)] [RED("armorPath")] public inkWidgetPath ArmorPath { get; set; }
		[Ordinal(22)] [RED("armorBarPath")] public inkWidgetPath ArmorBarPath { get; set; }
		[Ordinal(23)] [RED("expBar")] public inkWidgetReference ExpBar { get; set; }
		[Ordinal(24)] [RED("expBarSpacer")] public inkWidgetReference ExpBarSpacer { get; set; }
		[Ordinal(25)] [RED("barsLayoutPath")] public inkCompoundWidgetReference BarsLayoutPath { get; set; }
		[Ordinal(26)] [RED("buffsHolder")] public inkCompoundWidgetReference BuffsHolder { get; set; }
		[Ordinal(27)] [RED("invulnerableTextPath")] public inkTextWidgetReference InvulnerableTextPath { get; set; }
		[Ordinal(28)] [RED("levelTextPath")] public inkTextWidgetReference LevelTextPath { get; set; }
		[Ordinal(29)] [RED("nextLevelTextPath")] public inkTextWidgetReference NextLevelTextPath { get; set; }
		[Ordinal(30)] [RED("healthTextPath")] public inkTextWidgetReference HealthTextPath { get; set; }
		[Ordinal(31)] [RED("maxHealthTextPath")] public inkTextWidgetReference MaxHealthTextPath { get; set; }
		[Ordinal(32)] [RED("quickhacksContainer")] public inkCompoundWidgetReference QuickhacksContainer { get; set; }
		[Ordinal(33)] [RED("expText")] public inkTextWidgetReference ExpText { get; set; }
		[Ordinal(34)] [RED("expTextLabel")] public inkTextWidgetReference ExpTextLabel { get; set; }
		[Ordinal(35)] [RED("lostHealthAggregationBar")] public inkWidgetReference LostHealthAggregationBar { get; set; }
		[Ordinal(36)] [RED("levelUpRectangle")] public inkWidgetReference LevelUpRectangle { get; set; }
		[Ordinal(37)] [RED("healthController")] public wCHandle<NameplateBarLogicController> HealthController { get; set; }
		[Ordinal(38)] [RED("armorController")] public wCHandle<ProgressBarSimpleWidgetLogicController> ArmorController { get; set; }
		[Ordinal(39)] [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(40)] [RED("buffWidget")] public wCHandle<inkWidget> BuffWidget { get; set; }
		[Ordinal(41)] [RED("HPBar")] public wCHandle<inkWidget> HPBar { get; set; }
		[Ordinal(42)] [RED("armorBar")] public wCHandle<inkWidget> ArmorBar { get; set; }
		[Ordinal(43)] [RED("invulnerableText")] public wCHandle<inkTextWidget> InvulnerableText { get; set; }
		[Ordinal(44)] [RED("animHideTemp")] public CHandle<inkanimDefinition> AnimHideTemp { get; set; }
		[Ordinal(45)] [RED("animShortFade")] public CHandle<inkanimDefinition> AnimShortFade { get; set; }
		[Ordinal(46)] [RED("animLongFade")] public CHandle<inkanimDefinition> AnimLongFade { get; set; }
		[Ordinal(47)] [RED("animHideHPProxy")] public CHandle<inkanimProxy> AnimHideHPProxy { get; set; }
		[Ordinal(48)] [RED("delayAnimation")] public CHandle<inkanimDefinition> DelayAnimation { get; set; }
		[Ordinal(49)] [RED("animCreated")] public CBool AnimCreated { get; set; }
		[Ordinal(50)] [RED("aggregatingActive")] public CBool AggregatingActive { get; set; }
		[Ordinal(51)] [RED("countingStartHealth")] public CInt32 CountingStartHealth { get; set; }
		[Ordinal(52)] [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(53)] [RED("previousHealth")] public CInt32 PreviousHealth { get; set; }
		[Ordinal(54)] [RED("maximumHealth")] public CInt32 MaximumHealth { get; set; }
		[Ordinal(55)] [RED("quickhacksMemoryPercent")] public CFloat QuickhacksMemoryPercent { get; set; }
		[Ordinal(56)] [RED("currentArmor")] public CInt32 CurrentArmor { get; set; }
		[Ordinal(57)] [RED("maximumArmor")] public CInt32 MaximumArmor { get; set; }
		[Ordinal(58)] [RED("quickhackBarArray")] public CArray<wCHandle<inkWidget>> QuickhackBarArray { get; set; }
		[Ordinal(59)] [RED("maxQuickhackBars")] public CInt32 MaxQuickhackBars { get; set; }
		[Ordinal(60)] [RED("usedQuickhacks")] public CInt32 UsedQuickhacks { get; set; }
		[Ordinal(61)] [RED("buffsVisible")] public CBool BuffsVisible { get; set; }
		[Ordinal(62)] [RED("isUnarmedRightHand")] public CBool IsUnarmedRightHand { get; set; }
		[Ordinal(63)] [RED("isUnarmedLeftHand")] public CBool IsUnarmedLeftHand { get; set; }
		[Ordinal(64)] [RED("currentVisionPSM")] public CEnum<gamePSMVision> CurrentVisionPSM { get; set; }
		[Ordinal(65)] [RED("combatModePSM")] public CEnum<gamePSMCombat> CombatModePSM { get; set; }
		[Ordinal(66)] [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(67)] [RED("godModeStatListener")] public CHandle<GodModeStatListener> GodModeStatListener { get; set; }
		[Ordinal(68)] [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(69)] [RED("characterCurrentXPListener")] public CUInt32 CharacterCurrentXPListener { get; set; }
		[Ordinal(70)] [RED("levelUpBlackboard")] public CHandle<gameIBlackboard> LevelUpBlackboard { get; set; }
		[Ordinal(71)] [RED("playerLevelUpListener")] public CUInt32 PlayerLevelUpListener { get; set; }
		[Ordinal(72)] [RED("currentLevel")] public CInt32 CurrentLevel { get; set; }
		[Ordinal(73)] [RED("playerObject")] public wCHandle<gameObject> PlayerObject { get; set; }
		[Ordinal(74)] [RED("playerDevelopmentSystem")] public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem { get; set; }
		[Ordinal(75)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }

		public healthbarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
