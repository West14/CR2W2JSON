using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryGenericItemChooser : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("itemContainer")] public inkCompoundWidgetReference ItemContainer { get; set; }
		[Ordinal(2)] [RED("slotsCategory")] public inkWidgetReference SlotsCategory { get; set; }
		[Ordinal(3)] [RED("slotsRootContainer")] public inkWidgetReference SlotsRootContainer { get; set; }
		[Ordinal(4)] [RED("slotsRootLabel")] public inkTextWidgetReference SlotsRootLabel { get; set; }
		[Ordinal(5)] [RED("slotsContainer")] public inkCompoundWidgetReference SlotsContainer { get; set; }
		[Ordinal(6)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(7)] [RED("inventoryDataManager")] public CHandle<InventoryDataManagerV2> InventoryDataManager { get; set; }
		[Ordinal(8)] [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(9)] [RED("itemDisplay")] public CHandle<InventoryItemDisplayController> ItemDisplay { get; set; }
		[Ordinal(10)] [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(11)] [RED("selectedItem")] public CHandle<InventoryItemDisplayController> SelectedItem { get; set; }
		[Ordinal(12)] [RED("tooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }

		public InventoryGenericItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
