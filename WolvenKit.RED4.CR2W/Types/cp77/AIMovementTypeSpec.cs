using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMovementTypeSpec : CVariable
	{
		[Ordinal(0)] [RED("useNPCMovementParams")] public CBool UseNPCMovementParams { get; set; }
		[Ordinal(1)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }

		public AIMovementTypeSpec(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
