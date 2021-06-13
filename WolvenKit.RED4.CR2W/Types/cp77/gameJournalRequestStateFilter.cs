using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestStateFilter : CVariable
	{
		[Ordinal(0)] [RED("inactive")] public CBool Inactive { get; set; }
		[Ordinal(1)] [RED("active")] public CBool Active { get; set; }
		[Ordinal(2)] [RED("succeeded")] public CBool Succeeded { get; set; }
		[Ordinal(3)] [RED("failed")] public CBool Failed { get; set; }

		public gameJournalRequestStateFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
