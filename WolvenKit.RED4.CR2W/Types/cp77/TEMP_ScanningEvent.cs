using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TEMP_ScanningEvent : redEvent
	{
		[Ordinal(0)] [RED("clue")] public CName Clue { get; set; }
		[Ordinal(1)] [RED("showUI")] public CBool ShowUI { get; set; }

		public TEMP_ScanningEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
