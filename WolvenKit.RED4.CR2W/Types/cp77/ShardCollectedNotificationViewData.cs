using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("entry")] public CHandle<gameJournalOnscreen> Entry { get; set; }
		[Ordinal(6)] [RED("isCrypted")] public CBool IsCrypted { get; set; }
		[Ordinal(7)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(8)] [RED("shardTitle")] public CString ShardTitle { get; set; }

		public ShardCollectedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
