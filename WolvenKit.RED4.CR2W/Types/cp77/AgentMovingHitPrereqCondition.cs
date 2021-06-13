using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AgentMovingHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("isMoving")] public CBool IsMoving { get; set; }
		[Ordinal(2)] [RED("object")] public CName Object { get; set; }

		public AgentMovingHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
