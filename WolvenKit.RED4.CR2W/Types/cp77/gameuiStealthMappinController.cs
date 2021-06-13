using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStealthMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] [RED("animImage")] public inkImageWidgetReference AnimImage { get; set; }
		[Ordinal(12)] [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }
		[Ordinal(13)] [RED("fill")] public inkWidgetReference Fill { get; set; }
		[Ordinal(14)] [RED("eyeFillWhite")] public inkWidgetReference EyeFillWhite { get; set; }
		[Ordinal(15)] [RED("eyeFillBlack")] public inkWidgetReference EyeFillBlack { get; set; }
		[Ordinal(16)] [RED("markExclamation")] public inkTextWidgetReference MarkExclamation { get; set; }
		[Ordinal(17)] [RED("distance")] public inkTextWidgetReference Distance { get; set; }
		[Ordinal(18)] [RED("mainArt")] public inkWidgetReference MainArt { get; set; }
		[Ordinal(19)] [RED("frame")] public inkImageWidgetReference Frame { get; set; }
		[Ordinal(20)] [RED("eliteFrameName")] public CName EliteFrameName { get; set; }
		[Ordinal(21)] [RED("eliteFrameSize")] public Vector2 EliteFrameSize { get; set; }
		[Ordinal(22)] [RED("objectMarker")] public inkWidgetReference ObjectMarker { get; set; }
		[Ordinal(23)] [RED("levelIcon")] public inkImageWidgetReference LevelIcon { get; set; }
		[Ordinal(24)] [RED("statusEffectHolder")] public inkWidgetReference StatusEffectHolder { get; set; }
		[Ordinal(25)] [RED("statusEffectIcon")] public inkImageWidgetReference StatusEffectIcon { get; set; }
		[Ordinal(26)] [RED("statusEffectTimer")] public inkTextWidgetReference StatusEffectTimer { get; set; }
		[Ordinal(27)] [RED("taggedContainer")] public inkWidgetReference TaggedContainer { get; set; }
		[Ordinal(28)] [RED("ownerObject")] public wCHandle<gameObject> OwnerObject { get; set; }
		[Ordinal(29)] [RED("ownerNPC")] public wCHandle<NPCPuppet> OwnerNPC { get; set; }
		[Ordinal(30)] [RED("ownerDevice")] public wCHandle<Device> OwnerDevice { get; set; }
		[Ordinal(31)] [RED("mappin")] public wCHandle<gamemappinsStealthMappin> Mappin { get; set; }
		[Ordinal(32)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(33)] [RED("canvas")] public wCHandle<inkWidget> Canvas { get; set; }
		[Ordinal(34)] [RED("nameplateController")] public wCHandle<gameuiNpcNameplateGameController> NameplateController { get; set; }
		[Ordinal(35)] [RED("isFriendly")] public CBool IsFriendly { get; set; }
		[Ordinal(36)] [RED("isFriendlyFromHack")] public CBool IsFriendlyFromHack { get; set; }
		[Ordinal(37)] [RED("isHostile")] public CBool IsHostile { get; set; }
		[Ordinal(38)] [RED("isAggressive")] public CBool IsAggressive { get; set; }
		[Ordinal(39)] [RED("isDevice")] public CBool IsDevice { get; set; }
		[Ordinal(40)] [RED("isDrone")] public CBool IsDrone { get; set; }
		[Ordinal(41)] [RED("isMech")] public CBool IsMech { get; set; }
		[Ordinal(42)] [RED("isCamera")] public CBool IsCamera { get; set; }
		[Ordinal(43)] [RED("isTurret")] public CBool IsTurret { get; set; }
		[Ordinal(44)] [RED("isHiddenByQuest")] public CBool IsHiddenByQuest { get; set; }
		[Ordinal(45)] [RED("NPCRarity")] public CEnum<gamedataNPCRarity> NPCRarity { get; set; }
		[Ordinal(46)] [RED("puppetStateBlackboard")] public CHandle<gameIBlackboard> PuppetStateBlackboard { get; set; }
		[Ordinal(47)] [RED("highLevelState")] public CEnum<gamedataNPCHighLevelState> HighLevelState { get; set; }
		[Ordinal(48)] [RED("numberOfCombatants")] public CInt32 NumberOfCombatants { get; set; }
		[Ordinal(49)] [RED("waitingToExitCombat")] public CBool WaitingToExitCombat { get; set; }
		[Ordinal(50)] [RED("reaction")] public CEnum<gamedataOutput> Reaction { get; set; }
		[Ordinal(51)] [RED("lastState")] public CEnum<gamedataNPCHighLevelState> LastState { get; set; }
		[Ordinal(52)] [RED("lastReaction")] public CEnum<gamedataOutput> LastReaction { get; set; }
		[Ordinal(53)] [RED("lastPercent")] public CFloat LastPercent { get; set; }
		[Ordinal(54)] [RED("canSeePlayer")] public CBool CanSeePlayer { get; set; }
		[Ordinal(55)] [RED("squadInCombat")] public CBool SquadInCombat { get; set; }
		[Ordinal(56)] [RED("archetypeTextureName")] public CName ArchetypeTextureName { get; set; }
		[Ordinal(57)] [RED("isTagged")] public CBool IsTagged { get; set; }
		[Ordinal(58)] [RED("canHaveObjectMarker")] public CBool CanHaveObjectMarker { get; set; }
		[Ordinal(59)] [RED("canShowObjectMarker")] public CBool CanShowObjectMarker { get; set; }
		[Ordinal(60)] [RED("objectMarkerVisible")] public CBool ObjectMarkerVisible { get; set; }
		[Ordinal(61)] [RED("nameplateVisible")] public CBool NameplateVisible { get; set; }
		[Ordinal(62)] [RED("detectionVisible")] public CBool DetectionVisible { get; set; }
		[Ordinal(63)] [RED("inNameplateMode")] public CBool InNameplateMode { get; set; }
		[Ordinal(64)] [RED("objectMarkerFirstShowing")] public CBool ObjectMarkerFirstShowing { get; set; }
		[Ordinal(65)] [RED("statusEffectShowing")] public CBool StatusEffectShowing { get; set; }
		[Ordinal(66)] [RED("statusEffectCurrentPriority")] public CFloat StatusEffectCurrentPriority { get; set; }
		[Ordinal(67)] [RED("animationIsPlaying")] public CBool AnimationIsPlaying { get; set; }
		[Ordinal(68)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(69)] [RED("nameplateAnimationProxy")] public CHandle<inkanimProxy> NameplateAnimationProxy { get; set; }
		[Ordinal(70)] [RED("nameplateAnimationIsPlaying")] public CBool NameplateAnimationIsPlaying { get; set; }
		[Ordinal(71)] [RED("reprimandAnimationProxy")] public CHandle<inkanimProxy> ReprimandAnimationProxy { get; set; }
		[Ordinal(72)] [RED("reprimandAnimationIsPlaying")] public CBool ReprimandAnimationIsPlaying { get; set; }
		[Ordinal(73)] [RED("reprimandAnimationState")] public CEnum<gameReprimandMappinAnimationState> ReprimandAnimationState { get; set; }
		[Ordinal(74)] [RED("currentAnimState")] public CEnum<gameEnemyStealthAwarenessState> CurrentAnimState { get; set; }
		[Ordinal(75)] [RED("c_emptyThreshold")] public CFloat C_emptyThreshold { get; set; }
		[Ordinal(76)] [RED("c_awareToCombatThreshold")] public CFloat C_awareToCombatThreshold { get; set; }
		[Ordinal(77)] [RED("c_combatToAwareThreshold")] public CFloat C_combatToAwareThreshold { get; set; }
		[Ordinal(78)] [RED("c_deviceCombatToAwareThreshold")] public CFloat C_deviceCombatToAwareThreshold { get; set; }
		[Ordinal(79)] [RED("c_objectMarkerMaxDistance")] public CFloat C_objectMarkerMaxDistance { get; set; }
		[Ordinal(80)] [RED("c_objectMarkerMaxCameraDistance")] public CFloat C_objectMarkerMaxCameraDistance { get; set; }

		public gameuiStealthMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
