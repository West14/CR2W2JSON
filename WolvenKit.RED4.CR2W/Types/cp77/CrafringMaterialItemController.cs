using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrafringMaterialItemController : BaseButtonView
	{
		[Ordinal(2)] [RED("nameText")] public inkTextWidgetReference NameText { get; set; }
		[Ordinal(3)] [RED("quantityText")] public inkTextWidgetReference QuantityText { get; set; }
		[Ordinal(4)] [RED("quantityChangeText")] public inkTextWidgetReference QuantityChangeText { get; set; }
		[Ordinal(5)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(6)] [RED("frame")] public inkWidgetReference Frame { get; set; }
		[Ordinal(7)] [RED("data")] public InventoryItemData Data { get; set; }
		[Ordinal(8)] [RED("quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(9)] [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(10)] [RED("lastState")] public CEnum<CrafringMaterialItemHighlight> LastState { get; set; }

		public CrafringMaterialItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
