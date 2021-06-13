using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEntryVisitedStatusData : CVariable
	{
		[Ordinal(0)] [RED("entryPath")] public CHandle<gameJournalPath> EntryPath { get; set; }
		[Ordinal(1)] [RED("entryType")] public CName EntryType { get; set; }
		[Ordinal(2)] [RED("isVisited")] public CBool IsVisited { get; set; }

		public gameJournalEntryVisitedStatusData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
