using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterAttack_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("attackerRef")] public gameEntityReference AttackerRef { get; set; }
		[Ordinal(1)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
		[Ordinal(2)] [RED("isTargetPlayer")] public CBool IsTargetPlayer { get; set; }

		public questCharacterAttack_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
