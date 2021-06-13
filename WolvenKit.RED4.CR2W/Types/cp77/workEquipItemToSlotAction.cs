using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workEquipItemToSlotAction : workIWorkspotItemAction
	{
		[Ordinal(0)] [RED("item")] public TweakDBID Item { get; set; }
		[Ordinal(1)] [RED("itemSlot")] public TweakDBID ItemSlot { get; set; }

		public workEquipItemToSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
