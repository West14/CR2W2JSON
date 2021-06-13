using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListDistanceData : IScriptable
	{
		[Ordinal(0)] [RED("objective")] public wCHandle<gameJournalQuestObjective> Objective { get; set; }
		[Ordinal(1)] [RED("distance")] public CFloat Distance { get; set; }

		public QuestListDistanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
