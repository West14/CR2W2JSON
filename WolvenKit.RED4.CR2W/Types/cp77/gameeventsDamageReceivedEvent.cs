using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDamageReceivedEvent : redEvent
	{
		[Ordinal(0)] [RED("hitEvent")] public CHandle<gameeventsHitEvent> HitEvent { get; set; }
		[Ordinal(1)] [RED("totalDamageReceived")] public CFloat TotalDamageReceived { get; set; }

		public gameeventsDamageReceivedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
