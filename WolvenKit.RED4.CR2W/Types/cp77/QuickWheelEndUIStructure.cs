using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickWheelEndUIStructure : CVariable
	{
		[Ordinal(0)] [RED("ChosenItem")] public QuickSlotCommand ChosenItem { get; set; }
		[Ordinal(1)] [RED("WasUsed")] public CBool WasUsed { get; set; }
		[Ordinal(2)] [RED("WasAssignedToSlot")] public CBool WasAssignedToSlot { get; set; }
		[Ordinal(3)] [RED("WheelDirection")] public CEnum<EDPadSlot> WheelDirection { get; set; }

		public QuickWheelEndUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
