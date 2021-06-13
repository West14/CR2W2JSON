using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] [RED("backgroundContainer")] public inkCompoundWidgetReference BackgroundContainer { get; set; }
		[Ordinal(3)] [RED("nameText")] public inkTextWidgetReference NameText { get; set; }
		[Ordinal(4)] [RED("tierText")] public inkTextWidgetReference TierText { get; set; }
		[Ordinal(5)] [RED("durationWidget")] public inkWidgetReference DurationWidget { get; set; }
		[Ordinal(6)] [RED("uploadTimeWidget")] public inkWidgetReference UploadTimeWidget { get; set; }
		[Ordinal(7)] [RED("cooldownWidget")] public inkWidgetReference CooldownWidget { get; set; }
		[Ordinal(8)] [RED("memoryCostValueText")] public inkTextWidgetReference MemoryCostValueText { get; set; }
		[Ordinal(9)] [RED("damageWrapper")] public inkWidgetReference DamageWrapper { get; set; }
		[Ordinal(10)] [RED("damageLabel")] public inkTextWidgetReference DamageLabel { get; set; }
		[Ordinal(11)] [RED("damageValue")] public inkTextWidgetReference DamageValue { get; set; }
		[Ordinal(12)] [RED("healthPercentageLabel")] public inkTextWidgetReference HealthPercentageLabel { get; set; }
		[Ordinal(13)] [RED("priceContainer")] public inkWidgetReference PriceContainer { get; set; }
		[Ordinal(14)] [RED("priceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(15)] [RED("descriptionWrapper")] public inkWidgetReference DescriptionWrapper { get; set; }
		[Ordinal(16)] [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(17)] [RED("hackTypeWrapper")] public inkWidgetReference HackTypeWrapper { get; set; }
		[Ordinal(18)] [RED("hackTypeText")] public inkTextWidgetReference HackTypeText { get; set; }
		[Ordinal(19)] [RED("effectsList")] public inkCompoundWidgetReference EffectsList { get; set; }
		[Ordinal(20)] [RED("DEBUG_iconErrorWrapper")] public inkWidgetReference DEBUG_iconErrorWrapper { get; set; }
		[Ordinal(21)] [RED("DEBUG_iconErrorText")] public inkTextWidgetReference DEBUG_iconErrorText { get; set; }
		[Ordinal(22)] [RED("DEBUG_showAdditionalInfo")] public CBool DEBUG_showAdditionalInfo { get; set; }
		[Ordinal(23)] [RED("data")] public CHandle<InventoryTooltipData> Data { get; set; }
		[Ordinal(24)] [RED("quickHackData")] public InventoryTooltipData_QuickhackData QuickHackData { get; set; }

		public ProgramTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
