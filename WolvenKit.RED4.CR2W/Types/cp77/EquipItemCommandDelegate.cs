using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipItemCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("equipCommand")] public wCHandle<AIEquipCommand> EquipCommand { get; set; }
		[Ordinal(1)] [RED("unequipCommand")] public wCHandle<AIUnequipCommand> UnequipCommand { get; set; }
		[Ordinal(2)] [RED("slotIdName")] public TweakDBID SlotIdName { get; set; }
		[Ordinal(3)] [RED("itemIdName")] public TweakDBID ItemIdName { get; set; }

		public EquipItemCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
