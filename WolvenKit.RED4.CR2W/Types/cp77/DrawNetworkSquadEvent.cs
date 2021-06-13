using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrawNetworkSquadEvent : redEvent
	{
		[Ordinal(0)] [RED("shouldDraw")] public CBool ShouldDraw { get; set; }
		[Ordinal(1)] [RED("memberID")] public gamePersistentID MemberID { get; set; }
		[Ordinal(2)] [RED("fxResource")] public gameFxResource FxResource { get; set; }
		[Ordinal(3)] [RED("isPing")] public CBool IsPing { get; set; }
		[Ordinal(4)] [RED("revealMaster")] public CBool RevealMaster { get; set; }
		[Ordinal(5)] [RED("revealSlave")] public CBool RevealSlave { get; set; }
		[Ordinal(6)] [RED("memberOnly")] public CBool MemberOnly { get; set; }
		[Ordinal(7)] [RED("duration")] public CFloat Duration { get; set; }

		public DrawNetworkSquadEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
