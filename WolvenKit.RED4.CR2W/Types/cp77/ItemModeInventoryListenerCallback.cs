using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemModeInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] [RED("itemModeInstance")] public wCHandle<InventoryItemModeLogicController> ItemModeInstance { get; set; }

		public ItemModeInventoryListenerCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
