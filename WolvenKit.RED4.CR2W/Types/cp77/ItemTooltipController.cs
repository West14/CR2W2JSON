using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(3)] [RED("itemRarityText")] public inkTextWidgetReference ItemRarityText { get; set; }
		[Ordinal(4)] [RED("progressBar")] public inkWidgetReference ProgressBar { get; set; }
		[Ordinal(5)] [RED("recipeStatsTitle")] public inkTextWidgetReference RecipeStatsTitle { get; set; }
		[Ordinal(6)] [RED("categoriesWrapper")] public inkCompoundWidgetReference CategoriesWrapper { get; set; }
		[Ordinal(7)] [RED("backgroundContainer")] public inkCompoundWidgetReference BackgroundContainer { get; set; }
		[Ordinal(8)] [RED("topContainer")] public inkCompoundWidgetReference TopContainer { get; set; }
		[Ordinal(9)] [RED("headerContainer")] public inkCompoundWidgetReference HeaderContainer { get; set; }
		[Ordinal(10)] [RED("headerWeaponContainer")] public inkCompoundWidgetReference HeaderWeaponContainer { get; set; }
		[Ordinal(11)] [RED("headerItemContainer")] public inkCompoundWidgetReference HeaderItemContainer { get; set; }
		[Ordinal(12)] [RED("headerGrenadeContainer")] public inkCompoundWidgetReference HeaderGrenadeContainer { get; set; }
		[Ordinal(13)] [RED("headerArmorContainer")] public inkCompoundWidgetReference HeaderArmorContainer { get; set; }
		[Ordinal(14)] [RED("primmaryStatsContainer")] public inkCompoundWidgetReference PrimmaryStatsContainer { get; set; }
		[Ordinal(15)] [RED("secondaryStatsContainer")] public inkCompoundWidgetReference SecondaryStatsContainer { get; set; }
		[Ordinal(16)] [RED("recipeStatsContainer")] public inkCompoundWidgetReference RecipeStatsContainer { get; set; }
		[Ordinal(17)] [RED("recipeDamageTypesContainer")] public inkCompoundWidgetReference RecipeDamageTypesContainer { get; set; }
		[Ordinal(18)] [RED("modsContainer")] public inkCompoundWidgetReference ModsContainer { get; set; }
		[Ordinal(19)] [RED("dedicatedModsContainer")] public inkCompoundWidgetReference DedicatedModsContainer { get; set; }
		[Ordinal(20)] [RED("descriptionContainer")] public inkCompoundWidgetReference DescriptionContainer { get; set; }
		[Ordinal(21)] [RED("craftedItemContainer")] public inkCompoundWidgetReference CraftedItemContainer { get; set; }
		[Ordinal(22)] [RED("bottomContainer")] public inkCompoundWidgetReference BottomContainer { get; set; }
		[Ordinal(23)] [RED("primmaryStatsList")] public inkCompoundWidgetReference PrimmaryStatsList { get; set; }
		[Ordinal(24)] [RED("secondaryStatsList")] public inkCompoundWidgetReference SecondaryStatsList { get; set; }
		[Ordinal(25)] [RED("recipeStatsTypesList")] public inkCompoundWidgetReference RecipeStatsTypesList { get; set; }
		[Ordinal(26)] [RED("recipeDamageTypesList")] public inkCompoundWidgetReference RecipeDamageTypesList { get; set; }
		[Ordinal(27)] [RED("modsList")] public inkCompoundWidgetReference ModsList { get; set; }
		[Ordinal(28)] [RED("dedicatedModsList")] public inkCompoundWidgetReference DedicatedModsList { get; set; }
		[Ordinal(29)] [RED("requiredLevelContainer")] public inkCompoundWidgetReference RequiredLevelContainer { get; set; }
		[Ordinal(30)] [RED("priceContainer")] public inkCompoundWidgetReference PriceContainer { get; set; }
		[Ordinal(31)] [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(32)] [RED("requireLevelText")] public inkTextWidgetReference RequireLevelText { get; set; }
		[Ordinal(33)] [RED("priceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(34)] [RED("dpsWrapper")] public inkWidgetReference DpsWrapper { get; set; }
		[Ordinal(35)] [RED("dpsArrow")] public inkImageWidgetReference DpsArrow { get; set; }
		[Ordinal(36)] [RED("dpsText")] public inkTextWidgetReference DpsText { get; set; }
		[Ordinal(37)] [RED("nonLethalText")] public inkTextWidgetReference NonLethalText { get; set; }
		[Ordinal(38)] [RED("damagePerHitValue")] public inkTextWidgetReference DamagePerHitValue { get; set; }
		[Ordinal(39)] [RED("attacksPerSecondValue")] public inkTextWidgetReference AttacksPerSecondValue { get; set; }
		[Ordinal(40)] [RED("silencerPartWrapper")] public inkWidgetReference SilencerPartWrapper { get; set; }
		[Ordinal(41)] [RED("scopePartWrapper")] public inkWidgetReference ScopePartWrapper { get; set; }
		[Ordinal(42)] [RED("craftedItemIcon")] public inkWidgetReference CraftedItemIcon { get; set; }
		[Ordinal(43)] [RED("grenadeDamageTypeWrapper")] public inkWidgetReference GrenadeDamageTypeWrapper { get; set; }
		[Ordinal(44)] [RED("grenadeDamageTypeIcon")] public inkImageWidgetReference GrenadeDamageTypeIcon { get; set; }
		[Ordinal(45)] [RED("grenadeRangeValue")] public inkTextWidgetReference GrenadeRangeValue { get; set; }
		[Ordinal(46)] [RED("grenadeRangeText")] public inkTextWidgetReference GrenadeRangeText { get; set; }
		[Ordinal(47)] [RED("grenadeDeliveryLabel")] public inkTextWidgetReference GrenadeDeliveryLabel { get; set; }
		[Ordinal(48)] [RED("grenadeDeliveryIcon")] public inkImageWidgetReference GrenadeDeliveryIcon { get; set; }
		[Ordinal(49)] [RED("grenadeDamageStatWrapper")] public inkWidgetReference GrenadeDamageStatWrapper { get; set; }
		[Ordinal(50)] [RED("grenadeDamageStatLabel")] public inkTextWidgetReference GrenadeDamageStatLabel { get; set; }
		[Ordinal(51)] [RED("grenadeDamageStatValue")] public inkTextWidgetReference GrenadeDamageStatValue { get; set; }
		[Ordinal(52)] [RED("armorStatArrow")] public inkImageWidgetReference ArmorStatArrow { get; set; }
		[Ordinal(53)] [RED("armorStatLabel")] public inkTextWidgetReference ArmorStatLabel { get; set; }
		[Ordinal(54)] [RED("quickhackStatWrapper")] public inkWidgetReference QuickhackStatWrapper { get; set; }
		[Ordinal(55)] [RED("quickhackCostValue")] public inkTextWidgetReference QuickhackCostValue { get; set; }
		[Ordinal(56)] [RED("quickhackDuration")] public inkTextWidgetReference QuickhackDuration { get; set; }
		[Ordinal(57)] [RED("quickhackCooldown")] public inkTextWidgetReference QuickhackCooldown { get; set; }
		[Ordinal(58)] [RED("quickhackUpload")] public inkTextWidgetReference QuickhackUpload { get; set; }
		[Ordinal(59)] [RED("damageTypeWrapper")] public inkWidgetReference DamageTypeWrapper { get; set; }
		[Ordinal(60)] [RED("damageTypeIcon")] public inkImageWidgetReference DamageTypeIcon { get; set; }
		[Ordinal(61)] [RED("equipedWrapper")] public inkWidgetReference EquipedWrapper { get; set; }
		[Ordinal(62)] [RED("itemTypeText")] public inkTextWidgetReference ItemTypeText { get; set; }
		[Ordinal(63)] [RED("itemPreviewWrapper")] public inkWidgetReference ItemPreviewWrapper { get; set; }
		[Ordinal(64)] [RED("itemPreviewIcon")] public inkImageWidgetReference ItemPreviewIcon { get; set; }
		[Ordinal(65)] [RED("itemPreviewIconicLines")] public inkWidgetReference ItemPreviewIconicLines { get; set; }
		[Ordinal(66)] [RED("itemWeightWrapper")] public inkWidgetReference ItemWeightWrapper { get; set; }
		[Ordinal(67)] [RED("itemWeightText")] public inkTextWidgetReference ItemWeightText { get; set; }
		[Ordinal(68)] [RED("itemAmmoWrapper")] public inkWidgetReference ItemAmmoWrapper { get; set; }
		[Ordinal(69)] [RED("itemAmmoText")] public inkTextWidgetReference ItemAmmoText { get; set; }
		[Ordinal(70)] [RED("itemRequirements")] public inkWidgetReference ItemRequirements { get; set; }
		[Ordinal(71)] [RED("itemLevelRequirements")] public inkWidgetReference ItemLevelRequirements { get; set; }
		[Ordinal(72)] [RED("itemStrenghtRequirements")] public inkWidgetReference ItemStrenghtRequirements { get; set; }
		[Ordinal(73)] [RED("itemAttributeRequirements")] public inkWidgetReference ItemAttributeRequirements { get; set; }
		[Ordinal(74)] [RED("itemSmartGunLinkRequirements")] public inkWidgetReference ItemSmartGunLinkRequirements { get; set; }
		[Ordinal(75)] [RED("itemLevelRequirementsValue")] public inkTextWidgetReference ItemLevelRequirementsValue { get; set; }
		[Ordinal(76)] [RED("itemStrenghtRequirementsValue")] public inkTextWidgetReference ItemStrenghtRequirementsValue { get; set; }
		[Ordinal(77)] [RED("itemAttributeRequirementsText")] public inkTextWidgetReference ItemAttributeRequirementsText { get; set; }
		[Ordinal(78)] [RED("weaponEvolutionWrapper")] public inkWidgetReference WeaponEvolutionWrapper { get; set; }
		[Ordinal(79)] [RED("weaponEvolutionIcon")] public inkImageWidgetReference WeaponEvolutionIcon { get; set; }
		[Ordinal(80)] [RED("weaponEvolutionName")] public inkTextWidgetReference WeaponEvolutionName { get; set; }
		[Ordinal(81)] [RED("weaponEvolutionDescription")] public inkTextWidgetReference WeaponEvolutionDescription { get; set; }
		[Ordinal(82)] [RED("DEBUG_iconErrorWrapper")] public inkWidgetReference DEBUG_iconErrorWrapper { get; set; }
		[Ordinal(83)] [RED("DEBUG_iconErrorText")] public inkTextWidgetReference DEBUG_iconErrorText { get; set; }
		[Ordinal(84)] [RED("DEBUG_showAdditionalInfo")] public CBool DEBUG_showAdditionalInfo { get; set; }
		[Ordinal(85)] [RED("data")] public CHandle<InventoryTooltipData> Data { get; set; }
		[Ordinal(86)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(87)] [RED("playAnimation")] public CBool PlayAnimation { get; set; }

		public ItemTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
