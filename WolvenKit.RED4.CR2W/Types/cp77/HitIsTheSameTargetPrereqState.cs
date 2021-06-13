using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIsTheSameTargetPrereqState : GenericHitPrereqState
	{
		[Ordinal(2)] [RED("previousTarget")] public wCHandle<gameObject> PreviousTarget { get; set; }
		[Ordinal(3)] [RED("previousSource")] public wCHandle<gameObject> PreviousSource { get; set; }
		[Ordinal(4)] [RED("previousWeapon")] public wCHandle<gameweaponObject> PreviousWeapon { get; set; }

		public HitIsTheSameTargetPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
