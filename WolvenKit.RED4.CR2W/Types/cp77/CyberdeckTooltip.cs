using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckTooltip : AGenericTooltipController
	{
		[Ordinal(2)] [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(3)] [RED("itemRarityText")] public inkTextWidgetReference ItemRarityText { get; set; }
		[Ordinal(4)] [RED("rarityBars")] public inkWidgetReference RarityBars { get; set; }
		[Ordinal(5)] [RED("itemLevelText")] public inkTextWidgetReference ItemLevelText { get; set; }
		[Ordinal(6)] [RED("categoriesWrapper")] public inkCompoundWidgetReference CategoriesWrapper { get; set; }
		[Ordinal(7)] [RED("topContainer")] public inkCompoundWidgetReference TopContainer { get; set; }
		[Ordinal(8)] [RED("headerContainer")] public inkCompoundWidgetReference HeaderContainer { get; set; }
		[Ordinal(9)] [RED("statsContainer")] public inkCompoundWidgetReference StatsContainer { get; set; }
		[Ordinal(10)] [RED("descriptionContainer")] public inkCompoundWidgetReference DescriptionContainer { get; set; }
		[Ordinal(11)] [RED("bottomContainer")] public inkCompoundWidgetReference BottomContainer { get; set; }
		[Ordinal(12)] [RED("statsList")] public inkCompoundWidgetReference StatsList { get; set; }
		[Ordinal(13)] [RED("priceContainer")] public inkCompoundWidgetReference PriceContainer { get; set; }
		[Ordinal(14)] [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(15)] [RED("priceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(16)] [RED("equipedWrapper")] public inkWidgetReference EquipedWrapper { get; set; }
		[Ordinal(17)] [RED("itemTypeText")] public inkTextWidgetReference ItemTypeText { get; set; }
		[Ordinal(18)] [RED("itemWeightWrapper")] public inkWidgetReference ItemWeightWrapper { get; set; }
		[Ordinal(19)] [RED("itemWeightText")] public inkTextWidgetReference ItemWeightText { get; set; }
		[Ordinal(20)] [RED("cybderdeckBaseMemoryValue")] public inkTextWidgetReference CybderdeckBaseMemoryValue { get; set; }
		[Ordinal(21)] [RED("cybderdeckBufferValue")] public inkTextWidgetReference CybderdeckBufferValue { get; set; }
		[Ordinal(22)] [RED("cybderdeckSlotsValue")] public inkTextWidgetReference CybderdeckSlotsValue { get; set; }
		[Ordinal(23)] [RED("deviceHacksGrid")] public inkCompoundWidgetReference DeviceHacksGrid { get; set; }
		[Ordinal(24)] [RED("itemIconImage")] public inkImageWidgetReference ItemIconImage { get; set; }
		[Ordinal(25)] [RED("itemAttributeRequirements")] public inkWidgetReference ItemAttributeRequirements { get; set; }
		[Ordinal(26)] [RED("itemAttributeRequirementsText")] public inkTextWidgetReference ItemAttributeRequirementsText { get; set; }
		[Ordinal(27)] [RED("rarityBarsController")] public CHandle<LevelBarsController> RarityBarsController { get; set; }
		[Ordinal(28)] [RED("data")] public CHandle<InventoryTooltipData> Data { get; set; }
		[Ordinal(29)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public CyberdeckTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
