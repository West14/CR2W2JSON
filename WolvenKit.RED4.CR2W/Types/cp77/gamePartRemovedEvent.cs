using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePartRemovedEvent : redEvent
	{
		[Ordinal(0)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)] [RED("removedPartID")] public gameItemID RemovedPartID { get; set; }

		public gamePartRemovedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
