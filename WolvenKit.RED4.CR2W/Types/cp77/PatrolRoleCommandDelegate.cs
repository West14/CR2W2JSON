using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PatrolRoleCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("patrolWithWeapon")] public CBool PatrolWithWeapon { get; set; }
		[Ordinal(1)] [RED("forceAlerted")] public CBool ForceAlerted { get; set; }

		public PatrolRoleCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
