using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] [RED("state")] public wCHandle<ItemInSlotPrereqState> State { get; set; }

		public ItemInSlotCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
