using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnTalkOnReturn_Operation : scnIInterruptManager_Operation
	{
		[Ordinal(0)] [RED("talkOnReturn")] public CBool TalkOnReturn { get; set; }

		public scnTalkOnReturn_Operation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
