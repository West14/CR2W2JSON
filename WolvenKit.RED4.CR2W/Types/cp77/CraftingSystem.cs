using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("lastActionStatus")] public CBool LastActionStatus { get; set; }
		[Ordinal(1)] [RED("playerCraftBook")] public CHandle<CraftBook> PlayerCraftBook { get; set; }
		[Ordinal(2)] [RED("callback")] public CHandle<CraftingSystemInventoryCallback> Callback { get; set; }
		[Ordinal(3)] [RED("inventoryListener")] public CHandle<gameInventoryScriptListener> InventoryListener { get; set; }
		[Ordinal(4)] [RED("itemIconGender")] public CEnum<gameItemIconGender> ItemIconGender { get; set; }

		public CraftingSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
