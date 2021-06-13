using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotUIStructure : CVariable
	{
		[Ordinal(0)] [RED("ItemIndex")] public CInt32 ItemIndex { get; set; }
		[Ordinal(1)] [RED("OperationResult")] public CBool OperationResult { get; set; }

		public QuickSlotUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
