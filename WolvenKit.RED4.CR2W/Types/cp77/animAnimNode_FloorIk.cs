using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloorIk : animAnimNode_FloorIkBase
	{
		[Ordinal(18)] [RED("pelvis")] public animSBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set; }
		[Ordinal(19)] [RED("legs")] public animSBehaviorConstraintNodeFloorIKLegsData Legs { get; set; }
		[Ordinal(20)] [RED("leftLegIK")] public animSTwoBonesIKSolverData LeftLegIK { get; set; }
		[Ordinal(21)] [RED("rightLegIK")] public animSTwoBonesIKSolverData RightLegIK { get; set; }

		public animAnimNode_FloorIk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
