using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetAsQuestImportantEvent : redEvent
	{
		[Ordinal(0)] [RED("isImportant")] public CBool IsImportant { get; set; }
		[Ordinal(1)] [RED("propagateToSlaves")] public CBool PropagateToSlaves { get; set; }

		public gameSetAsQuestImportantEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
