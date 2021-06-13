using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DpadWheelGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("haskMarkContainer")] public inkCompoundWidgetReference HaskMarkContainer { get; set; }
		[Ordinal(4)] [RED("itemContainer")] public inkCompoundWidgetReference ItemContainer { get; set; }
		[Ordinal(5)] [RED("selectorWrapper")] public inkWidgetReference SelectorWrapper { get; set; }
		[Ordinal(6)] [RED("centerIcon")] public inkWidgetReference CenterIcon { get; set; }
		[Ordinal(7)] [RED("centerGlow")] public inkWidgetReference CenterGlow { get; set; }
		[Ordinal(8)] [RED("itemLabel")] public inkTextWidgetReference ItemLabel { get; set; }
		[Ordinal(9)] [RED("itemDesc")] public inkTextWidgetReference ItemDesc { get; set; }
		[Ordinal(10)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(11)] [RED("indicator02")] public inkImageWidgetReference Indicator02 { get; set; }
		[Ordinal(12)] [RED("indicator03")] public inkImageWidgetReference Indicator03 { get; set; }
		[Ordinal(13)] [RED("indicator04")] public inkImageWidgetReference Indicator04 { get; set; }
		[Ordinal(14)] [RED("indicator05")] public inkImageWidgetReference Indicator05 { get; set; }
		[Ordinal(15)] [RED("indicator06")] public inkImageWidgetReference Indicator06 { get; set; }
		[Ordinal(16)] [RED("indicator07")] public inkImageWidgetReference Indicator07 { get; set; }
		[Ordinal(17)] [RED("indicator08")] public inkImageWidgetReference Indicator08 { get; set; }
		[Ordinal(18)] [RED("itemDistance")] public CFloat ItemDistance { get; set; }
		[Ordinal(19)] [RED("hashMarkDistance")] public CFloat HashMarkDistance { get; set; }
		[Ordinal(20)] [RED("minDistance")] public CFloat MinDistance { get; set; }
		[Ordinal(21)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(22)] [RED("Player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(23)] [RED("QuickSlotsManager")] public wCHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(24)] [RED("InventoryDataManager")] public CHandle<InventoryDataManagerV2> InventoryDataManager { get; set; }
		[Ordinal(25)] [RED("dpadItemsList")] public CArray<CHandle<DpadWheelItemController>> DpadItemsList { get; set; }
		[Ordinal(26)] [RED("commandsList")] public CArray<QuickSlotCommand> CommandsList { get; set; }
		[Ordinal(27)] [RED("selectedWheelItem")] public wCHandle<DpadWheelItemController> SelectedWheelItem { get; set; }
		[Ordinal(28)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(29)] [RED("selectedIndicator")] public inkWidgetReference SelectedIndicator { get; set; }
		[Ordinal(30)] [RED("angleInterval")] public CFloat AngleInterval { get; set; }
		[Ordinal(31)] [RED("previousAmount")] public CFloat PreviousAmount { get; set; }
		[Ordinal(32)] [RED("previousAngle")] public CFloat PreviousAngle { get; set; }
		[Ordinal(33)] [RED("data")] public QuickWheelStartUIStructure Data { get; set; }
		[Ordinal(34)] [RED("masterListOfAllCyberware")] public CArray<AbilityData> MasterListOfAllCyberware { get; set; }
		[Ordinal(35)] [RED("listOfUnassignedCyberware")] public CArray<AbilityData> ListOfUnassignedCyberware { get; set; }
		[Ordinal(36)] [RED("dpadWheelOpen")] public CBool DpadWheelOpen { get; set; }
		[Ordinal(37)] [RED("neutralChoiceDelayId")] public gameDelayID NeutralChoiceDelayId { get; set; }
		[Ordinal(38)] [RED("previouslySelectedData")] public QuickSlotCommand PreviouslySelectedData { get; set; }
		[Ordinal(39)] [RED("UiQuickItemsBlackboard")] public CHandle<gameIBlackboard> UiQuickItemsBlackboard { get; set; }
		[Ordinal(40)] [RED("UiQuickSlotDef")] public CHandle<UI_QuickSlotsDataDef> UiQuickSlotDef { get; set; }
		[Ordinal(41)] [RED("DPadWheelAngleBBID")] public CUInt32 DPadWheelAngleBBID { get; set; }
		[Ordinal(42)] [RED("DPadWheelInterationStartedBBID")] public CUInt32 DPadWheelInterationStartedBBID { get; set; }
		[Ordinal(43)] [RED("DPadWheelInterationEndedBBID")] public CUInt32 DPadWheelInterationEndedBBID { get; set; }
		[Ordinal(44)] [RED("DpadWheelCyberwareAssignedBBID")] public CUInt32 DpadWheelCyberwareAssignedBBID { get; set; }

		public DpadWheelGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
