using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTopThreatToCombatTarget : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("refreshTimer")] public CFloat RefreshTimer { get; set; }
		[Ordinal(1)] [RED("previousChecktime")] public CFloat PreviousChecktime { get; set; }
		[Ordinal(2)] [RED("targetTrackerComponent")] public CHandle<TargetTrackingExtension> TargetTrackerComponent { get; set; }
		[Ordinal(3)] [RED("movePoliciesComponent")] public CHandle<movePoliciesComponent> MovePoliciesComponent { get; set; }
		[Ordinal(4)] [RED("targetChangeTime")] public CFloat TargetChangeTime { get; set; }

		public SetTopThreatToCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
