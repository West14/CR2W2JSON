using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questWarningMessage_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("message")] public CString Message { get; set; }
		[Ordinal(1)] [RED("localizedMessage")] public LocalizationString LocalizedMessage { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("show")] public CBool Show { get; set; }
		[Ordinal(4)] [RED("instant")] public CBool Instant { get; set; }

		public questWarningMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
