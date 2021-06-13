using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneMessagePopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("content")] public inkWidgetReference Content { get; set; }
		[Ordinal(3)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(4)] [RED("avatarImage")] public inkImageWidgetReference AvatarImage { get; set; }
		[Ordinal(5)] [RED("menuBackgrouns")] public inkWidgetReference MenuBackgrouns { get; set; }
		[Ordinal(6)] [RED("hintTrack")] public inkWidgetReference HintTrack { get; set; }
		[Ordinal(7)] [RED("hintClose")] public inkWidgetReference HintClose { get; set; }
		[Ordinal(8)] [RED("hintReply")] public inkWidgetReference HintReply { get; set; }
		[Ordinal(9)] [RED("hintMessenger")] public inkWidgetReference HintMessenger { get; set; }
		[Ordinal(10)] [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(11)] [RED("blackboardDef")] public CHandle<UI_ComDeviceDef> BlackboardDef { get; set; }
		[Ordinal(12)] [RED("uiSystem")] public CHandle<gameuiGameSystemUI> UiSystem { get; set; }
		[Ordinal(13)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(14)] [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(15)] [RED("data")] public CHandle<JournalNotificationData> Data { get; set; }
		[Ordinal(16)] [RED("entry")] public wCHandle<gameJournalPhoneMessage> Entry { get; set; }
		[Ordinal(17)] [RED("contactEntry")] public wCHandle<gameJournalContact> ContactEntry { get; set; }
		[Ordinal(18)] [RED("attachment")] public wCHandle<gameJournalEntry> Attachment { get; set; }
		[Ordinal(19)] [RED("attachmentHash")] public CUInt32 AttachmentHash { get; set; }
		[Ordinal(20)] [RED("activeEntry")] public wCHandle<gameJournalEntry> ActiveEntry { get; set; }
		[Ordinal(21)] [RED("dialogViewController")] public wCHandle<MessengerDialogViewController> DialogViewController { get; set; }
		[Ordinal(22)] [RED("proxy")] public CHandle<inkanimProxy> Proxy { get; set; }

		public PhoneMessagePopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
