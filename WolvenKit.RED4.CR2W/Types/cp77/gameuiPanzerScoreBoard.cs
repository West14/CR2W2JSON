using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreBoard : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] [RED("scoreboardList")] public inkVerticalPanelWidgetReference ScoreboardList { get; set; }
		[Ordinal(2)] [RED("champions")] public CArray<gameuiPanzerScoreRecordData> Champions { get; set; }
		[Ordinal(3)] [RED("recordWidgetLibraryName")] public CName RecordWidgetLibraryName { get; set; }

		public gameuiPanzerScoreBoard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
