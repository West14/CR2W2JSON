using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSimpleScreenMessage : CVariable
	{
		[Ordinal(0)] [RED("isShown")] public CBool IsShown { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)] [RED("message")] public CString Message { get; set; }
		[Ordinal(3)] [RED("isInstant")] public CBool IsInstant { get; set; }

		public gameSimpleScreenMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
