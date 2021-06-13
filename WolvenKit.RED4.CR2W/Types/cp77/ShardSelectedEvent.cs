using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardSelectedEvent : redEvent
	{
		[Ordinal(0)] [RED("group")] public CBool Group { get; set; }
		[Ordinal(1)] [RED("entryHash")] public CInt32 EntryHash { get; set; }
		[Ordinal(2)] [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(3)] [RED("data")] public wCHandle<ShardEntryData> Data { get; set; }

		public ShardSelectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
