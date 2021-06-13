using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisInteractionChoiceData : CVariable
	{
		[Ordinal(0)] [RED("inputAction")] public CName InputAction { get; set; }
		[Ordinal(1)] [RED("rawInputKey")] public CEnum<EInputKey> RawInputKey { get; set; }
		[Ordinal(2)] [RED("isHoldAction")] public CBool IsHoldAction { get; set; }
		[Ordinal(3)] [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(4)] [RED("type")] public gameinteractionsChoiceTypeWrapper Type { get; set; }
		[Ordinal(5)] [RED("data")] public CArray<CVariant> Data { get; set; }
		[Ordinal(6)] [RED("captionParts")] public gameinteractionsChoiceCaption CaptionParts { get; set; }

		public gameinteractionsvisInteractionChoiceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
