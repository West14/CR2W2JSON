using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScanEvent : redEvent
	{
		[Ordinal(0)] [RED("clue")] public CString Clue { get; set; }
		[Ordinal(1)] [RED("isAvailable")] public CBool IsAvailable { get; set; }

		public ScanEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
