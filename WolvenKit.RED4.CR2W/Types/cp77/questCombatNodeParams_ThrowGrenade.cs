using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_ThrowGrenade : questCombatNodeParams
	{
		[Ordinal(0)] [RED("targetOverrideNode")] public NodeRef TargetOverrideNode { get; set; }
		[Ordinal(1)] [RED("targetOverridePuppet")] public gameEntityReference TargetOverridePuppet { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("once")] public CBool Once { get; set; }
		[Ordinal(4)] [RED("immediately")] public CBool Immediately { get; set; }

		public questCombatNodeParams_ThrowGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
