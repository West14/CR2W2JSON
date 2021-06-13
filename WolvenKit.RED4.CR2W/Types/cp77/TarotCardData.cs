using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardData : CVariable
	{
		[Ordinal(0)] [RED("empty")] public CBool Empty { get; set; }
		[Ordinal(1)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(2)] [RED("imagePath")] public CName ImagePath { get; set; }
		[Ordinal(3)] [RED("label")] public CString Label { get; set; }
		[Ordinal(4)] [RED("desc")] public CString Desc { get; set; }

		public TarotCardData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
