using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeyItemController : GenericHotkeyController
	{
		[Ordinal(19)] [RED("hotkeyItemSlot")] public inkWidgetReference HotkeyItemSlot { get; set; }
		[Ordinal(20)] [RED("hotkeyItemController")] public CHandle<InventoryItemDisplayController> HotkeyItemController_ { get; set; }
		[Ordinal(21)] [RED("currentItem")] public InventoryItemData CurrentItem { get; set; }
		[Ordinal(22)] [RED("hotkeyBlackboard")] public CHandle<gameIBlackboard> HotkeyBlackboard { get; set; }
		[Ordinal(23)] [RED("hotkeyCallbackID")] public CUInt32 HotkeyCallbackID { get; set; }
		[Ordinal(24)] [RED("equipmentSystem")] public wCHandle<EquipmentSystem> EquipmentSystem { get; set; }
		[Ordinal(25)] [RED("inventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }

		public HotkeyItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
