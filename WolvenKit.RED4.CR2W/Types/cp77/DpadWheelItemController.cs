using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DpadWheelItemController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("selectorWrapper")] public inkWidgetReference SelectorWrapper { get; set; }
		[Ordinal(2)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)] [RED("displayWrapper")] public inkWidgetReference DisplayWrapper { get; set; }
		[Ordinal(4)] [RED("itemWrapper")] public inkWidgetReference ItemWrapper { get; set; }
		[Ordinal(5)] [RED("arrows")] public inkWidgetReference Arrows { get; set; }
		[Ordinal(6)] [RED("abilityIcon")] public inkImageWidgetReference AbilityIcon { get; set; }
		[Ordinal(7)] [RED("quickHackIcon")] public inkImageWidgetReference QuickHackIcon { get; set; }
		[Ordinal(8)] [RED("highlight02")] public inkImageWidgetReference Highlight02 { get; set; }
		[Ordinal(9)] [RED("highlight03")] public inkImageWidgetReference Highlight03 { get; set; }
		[Ordinal(10)] [RED("highlight04")] public inkImageWidgetReference Highlight04 { get; set; }
		[Ordinal(11)] [RED("highlight05")] public inkImageWidgetReference Highlight05 { get; set; }
		[Ordinal(12)] [RED("highlight06")] public inkImageWidgetReference Highlight06 { get; set; }
		[Ordinal(13)] [RED("highlight07")] public inkImageWidgetReference Highlight07 { get; set; }
		[Ordinal(14)] [RED("highlight08")] public inkImageWidgetReference Highlight08 { get; set; }
		[Ordinal(15)] [RED("textDist")] public CFloat TextDist { get; set; }
		[Ordinal(16)] [RED("weaponTextDist")] public CFloat WeaponTextDist { get; set; }
		[Ordinal(17)] [RED("data")] public QuickSlotCommand Data { get; set; }
		[Ordinal(18)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(19)] [RED("item")] public CHandle<InventoryItemDisplay> Item { get; set; }
		[Ordinal(20)] [RED("itemWidget")] public CHandle<inkWidget> ItemWidget { get; set; }
		[Ordinal(21)] [RED("InventoryDataManager")] public CHandle<InventoryDataManagerV2> InventoryDataManager { get; set; }
		[Ordinal(22)] [RED("highlight")] public inkImageWidgetReference Highlight { get; set; }
		[Ordinal(23)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(24)] [RED("abilityData")] public AbilityData AbilityData { get; set; }
		[Ordinal(25)] [RED("quickHackWheelDefIcon")] public CName QuickHackWheelDefIcon { get; set; }

		public DpadWheelItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
