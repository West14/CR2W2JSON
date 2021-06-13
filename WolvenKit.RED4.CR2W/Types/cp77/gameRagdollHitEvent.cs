using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRagdollHitEvent : gameeventsHitEvent
	{
		[Ordinal(12)] [RED("impactForce")] public CFloat ImpactForce { get; set; }
		[Ordinal(13)] [RED("speedDelta")] public CFloat SpeedDelta { get; set; }
		[Ordinal(14)] [RED("heightDelta")] public CFloat HeightDelta { get; set; }

		public gameRagdollHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
