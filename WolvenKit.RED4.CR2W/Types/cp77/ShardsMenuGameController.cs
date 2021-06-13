using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardsMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(4)] [RED("entryViewRef")] public inkCompoundWidgetReference EntryViewRef { get; set; }
		[Ordinal(5)] [RED("virtualList")] public inkWidgetReference VirtualList { get; set; }
		[Ordinal(6)] [RED("emptyPlaceholderRef")] public inkWidgetReference EmptyPlaceholderRef { get; set; }
		[Ordinal(7)] [RED("leftBlockControllerRef")] public inkWidgetReference LeftBlockControllerRef { get; set; }
		[Ordinal(8)] [RED("crackHint")] public inkWidgetReference CrackHint { get; set; }
		[Ordinal(9)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(10)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(11)] [RED("entryViewController")] public wCHandle<CodexEntryViewController> EntryViewController { get; set; }
		[Ordinal(12)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(13)] [RED("listController")] public wCHandle<ShardsVirtualNestedListController> ListController { get; set; }
		[Ordinal(14)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(15)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(16)] [RED("activeData")] public CHandle<CodexListSyncData> ActiveData { get; set; }
		[Ordinal(17)] [RED("hasNewCryptedEntries")] public CBool HasNewCryptedEntries { get; set; }
		[Ordinal(18)] [RED("isEncryptedEntrySelected")] public CBool IsEncryptedEntrySelected { get; set; }
		[Ordinal(19)] [RED("selectedData")] public CHandle<ShardEntryData> SelectedData { get; set; }
		[Ordinal(20)] [RED("mingameBB")] public CHandle<gameIBlackboard> MingameBB { get; set; }
		[Ordinal(21)] [RED("userDataEntry")] public CInt32 UserDataEntry { get; set; }
		[Ordinal(22)] [RED("doubleInputPreventionFlag")] public CBool DoubleInputPreventionFlag { get; set; }
		[Ordinal(23)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public ShardsMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
