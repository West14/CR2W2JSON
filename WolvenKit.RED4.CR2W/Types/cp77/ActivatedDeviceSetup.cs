using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceSetup : CVariable
	{
		[Ordinal(0)] [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(1)] [RED("disableOnActivation")] public CBool DisableOnActivation { get; set; }
		[Ordinal(2)] [RED("glitchOnActivation")] public CBool GlitchOnActivation { get; set; }
		[Ordinal(3)] [RED("vfxResource")] public gameFxResource VfxResource { get; set; }
		[Ordinal(4)] [RED("activationVFXname")] public CName ActivationVFXname { get; set; }
		[Ordinal(5)] [RED("hasSimpleInteraction")] public CBool HasSimpleInteraction { get; set; }
		[Ordinal(6)] [RED("hasSpiderbotInteraction")] public CBool HasSpiderbotInteraction { get; set; }
		[Ordinal(7)] [RED("hasQuickHack")] public CBool HasQuickHack { get; set; }
		[Ordinal(8)] [RED("hasQuickHackDistraction")] public CBool HasQuickHackDistraction { get; set; }
		[Ordinal(9)] [RED("alternativeInteractionName")] public TweakDBID AlternativeInteractionName { get; set; }
		[Ordinal(10)] [RED("alternativeSpiderbotInteractionName")] public TweakDBID AlternativeSpiderbotInteractionName { get; set; }
		[Ordinal(11)] [RED("alternativeQuickHackName")] public TweakDBID AlternativeQuickHackName { get; set; }
		[Ordinal(12)] [RED("activatedDeviceSkillChecks")] public CHandle<EngDemoContainer> ActivatedDeviceSkillChecks { get; set; }
		[Ordinal(13)] [RED("attackType")] public TweakDBID AttackType { get; set; }
		[Ordinal(14)] [RED("shouldActivateTrapOnAreaEnter")] public CBool ShouldActivateTrapOnAreaEnter { get; set; }
		[Ordinal(15)] [RED("deviceWidgetRecord")] public TweakDBID DeviceWidgetRecord { get; set; }
		[Ordinal(16)] [RED("thumbnailIconRecord")] public TweakDBID ThumbnailIconRecord { get; set; }
		[Ordinal(17)] [RED("actionWidgetRecord")] public TweakDBID ActionWidgetRecord { get; set; }

		public ActivatedDeviceSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
