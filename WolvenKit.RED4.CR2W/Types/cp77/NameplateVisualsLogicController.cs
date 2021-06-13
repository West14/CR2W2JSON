using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateVisualsLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(2)] [RED("bigIconMain")] public inkWidgetReference BigIconMain { get; set; }
		[Ordinal(3)] [RED("bigLevelText")] public inkTextWidgetReference BigLevelText { get; set; }
		[Ordinal(4)] [RED("nameTextMain")] public inkTextWidgetReference NameTextMain { get; set; }
		[Ordinal(5)] [RED("bigIconArt")] public inkImageWidgetReference BigIconArt { get; set; }
		[Ordinal(6)] [RED("preventionIcon")] public inkWidgetReference PreventionIcon { get; set; }
		[Ordinal(7)] [RED("levelContainer")] public inkImageWidgetReference LevelContainer { get; set; }
		[Ordinal(8)] [RED("nameFrame")] public inkWidgetReference NameFrame { get; set; }
		[Ordinal(9)] [RED("healthbarWidget")] public inkWidgetReference HealthbarWidget { get; set; }
		[Ordinal(10)] [RED("healthBarFull")] public inkWidgetReference HealthBarFull { get; set; }
		[Ordinal(11)] [RED("healthBarFrame")] public inkWidgetReference HealthBarFrame { get; set; }
		[Ordinal(12)] [RED("taggedIcon")] public inkWidgetReference TaggedIcon { get; set; }
		[Ordinal(13)] [RED("iconBG")] public inkWidgetReference IconBG { get; set; }
		[Ordinal(14)] [RED("civilianIcon")] public inkWidgetReference CivilianIcon { get; set; }
		[Ordinal(15)] [RED("stealthMappinSlot")] public inkCompoundWidgetReference StealthMappinSlot { get; set; }
		[Ordinal(16)] [RED("iconTextWrapper")] public inkCompoundWidgetReference IconTextWrapper { get; set; }
		[Ordinal(17)] [RED("container")] public inkWidgetReference Container { get; set; }
		[Ordinal(18)] [RED("LevelcontainerAndText")] public inkCompoundWidgetReference LevelcontainerAndText { get; set; }
		[Ordinal(19)] [RED("rareStars")] public inkCompoundWidgetReference RareStars { get; set; }
		[Ordinal(20)] [RED("eliteStars")] public inkCompoundWidgetReference EliteStars { get; set; }
		[Ordinal(21)] [RED("hardEnemy")] public inkImageWidgetReference HardEnemy { get; set; }
		[Ordinal(22)] [RED("hardEnemyWrapper")] public inkWidgetReference HardEnemyWrapper { get; set; }
		[Ordinal(23)] [RED("damagePreviewWrapper")] public inkWidgetReference DamagePreviewWrapper { get; set; }
		[Ordinal(24)] [RED("damagePreviewWidget")] public inkWidgetReference DamagePreviewWidget { get; set; }
		[Ordinal(25)] [RED("damagePreviewArrow")] public inkWidgetReference DamagePreviewArrow { get; set; }
		[Ordinal(26)] [RED("buffsList")] public inkHorizontalPanelWidgetReference BuffsList { get; set; }
		[Ordinal(27)] [RED("buffWidgets")] public CArray<wCHandle<inkWidget>> BuffWidgets { get; set; }
		[Ordinal(28)] [RED("cachedPuppet")] public wCHandle<gameObject> CachedPuppet { get; set; }
		[Ordinal(29)] [RED("cachedIncomingData")] public gameuiNPCNextToTheCrosshair CachedIncomingData { get; set; }
		[Ordinal(30)] [RED("isOfficer")] public CBool IsOfficer { get; set; }
		[Ordinal(31)] [RED("isBoss")] public CBool IsBoss { get; set; }
		[Ordinal(32)] [RED("isElite")] public CBool IsElite { get; set; }
		[Ordinal(33)] [RED("isRare")] public CBool IsRare { get; set; }
		[Ordinal(34)] [RED("isPrevention")] public CBool IsPrevention { get; set; }
		[Ordinal(35)] [RED("canCallReinforcements")] public CBool CanCallReinforcements { get; set; }
		[Ordinal(36)] [RED("isCivilian")] public CBool IsCivilian { get; set; }
		[Ordinal(37)] [RED("isBurning")] public CBool IsBurning { get; set; }
		[Ordinal(38)] [RED("isPoisoned")] public CBool IsPoisoned { get; set; }
		[Ordinal(39)] [RED("bossColor")] public CColor BossColor { get; set; }
		[Ordinal(40)] [RED("npcDefeated")] public CBool NpcDefeated { get; set; }
		[Ordinal(41)] [RED("isStealthMappinVisible")] public CBool IsStealthMappinVisible { get; set; }
		[Ordinal(42)] [RED("playerZone")] public CEnum<gamePSMZones> PlayerZone { get; set; }
		[Ordinal(43)] [RED("healthController")] public wCHandle<NameplateBarLogicController> HealthController { get; set; }
		[Ordinal(44)] [RED("hasCenterIcon")] public CBool HasCenterIcon { get; set; }
		[Ordinal(45)] [RED("animatingObject")] public inkWidgetReference AnimatingObject { get; set; }
		[Ordinal(46)] [RED("isAnimating")] public CBool IsAnimating { get; set; }
		[Ordinal(47)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(48)] [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(49)] [RED("preventionAnimProxy")] public CHandle<inkanimProxy> PreventionAnimProxy { get; set; }
		[Ordinal(50)] [RED("damagePreviewAnimProxy")] public CHandle<inkanimProxy> DamagePreviewAnimProxy { get; set; }
		[Ordinal(51)] [RED("isQuestTarget")] public CBool IsQuestTarget { get; set; }
		[Ordinal(52)] [RED("forceHide")] public CBool ForceHide { get; set; }
		[Ordinal(53)] [RED("isHardEnemy")] public CBool IsHardEnemy { get; set; }
		[Ordinal(54)] [RED("npcIsAggressive")] public CBool NpcIsAggressive { get; set; }
		[Ordinal(55)] [RED("playerAimingDownSights")] public CBool PlayerAimingDownSights { get; set; }
		[Ordinal(56)] [RED("playerInCombat")] public CBool PlayerInCombat { get; set; }
		[Ordinal(57)] [RED("playerInStealth")] public CBool PlayerInStealth { get; set; }
		[Ordinal(58)] [RED("healthNotFull")] public CBool HealthNotFull { get; set; }
		[Ordinal(59)] [RED("healthbarVisible")] public CBool HealthbarVisible { get; set; }
		[Ordinal(60)] [RED("levelContainerShouldBeVisible")] public CBool LevelContainerShouldBeVisible { get; set; }
		[Ordinal(61)] [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(62)] [RED("maximumHealth")] public CInt32 MaximumHealth { get; set; }
		[Ordinal(63)] [RED("currentDamagePreviewValue")] public CInt32 CurrentDamagePreviewValue { get; set; }

		public NameplateVisualsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
