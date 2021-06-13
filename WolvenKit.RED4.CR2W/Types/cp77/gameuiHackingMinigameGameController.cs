using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHackingMinigameGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("symbolsRecordTDBID")] public TweakDBID SymbolsRecordTDBID { get; set; }
		[Ordinal(3)] [RED("minigameDefaultsTDBID")] public TweakDBID MinigameDefaultsTDBID { get; set; }
		[Ordinal(4)] [RED("miniGameRecord")] public wCHandle<gamedataMinigame_Def_Record> MiniGameRecord { get; set; }
		[Ordinal(5)] [RED("dimension")] public CInt32 Dimension { get; set; }
		[Ordinal(6)] [RED("isTutorialActive")] public CBool IsTutorialActive { get; set; }
		[Ordinal(7)] [RED("isOfficerBreach")] public CBool IsOfficerBreach { get; set; }
		[Ordinal(8)] [RED("isRemoteBreach")] public CBool IsRemoteBreach { get; set; }
		[Ordinal(9)] [RED("isItemBreach")] public CBool IsItemBreach { get; set; }
		[Ordinal(10)] [RED("numberAttempts")] public CInt32 NumberAttempts { get; set; }
		[Ordinal(11)] [RED("tooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(12)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(13)] [RED("uiSystem")] public CHandle<gameuiGameSystemUI> UiSystem { get; set; }
		[Ordinal(14)] [RED("contextHelpOverlay")] public CBool ContextHelpOverlay { get; set; }
		[Ordinal(15)] [RED("bbMinigame")] public CHandle<gameIBlackboard> BbMinigame { get; set; }
		[Ordinal(16)] [RED("bbMinigameStateListener")] public CUInt32 BbMinigameStateListener { get; set; }
		[Ordinal(17)] [RED("bbUiData")] public CHandle<gameIBlackboard> BbUiData { get; set; }
		[Ordinal(18)] [RED("bbControllerStateListener")] public CUInt32 BbControllerStateListener { get; set; }

		public gameuiHackingMinigameGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
