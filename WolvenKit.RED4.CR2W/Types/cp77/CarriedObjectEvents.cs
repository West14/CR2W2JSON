using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarriedObjectEvents : OldUpperBodyEventsTransition
	{
		[Ordinal(0)] [RED("animFeature")] public CHandle<AnimFeature_Mounting> AnimFeature { get; set; }
		[Ordinal(1)] [RED("animCarryFeature")] public CHandle<AnimFeature_Carry> AnimCarryFeature { get; set; }
		[Ordinal(2)] [RED("leftHandFeature")] public CHandle<AnimFeature_LeftHandAnimation> LeftHandFeature { get; set; }
		[Ordinal(3)] [RED("AnimWrapperWeightSetterStrong")] public CHandle<entAnimWrapperWeightSetter> AnimWrapperWeightSetterStrong { get; set; }
		[Ordinal(4)] [RED("AnimWrapperWeightSetterFriendly")] public CHandle<entAnimWrapperWeightSetter> AnimWrapperWeightSetterFriendly { get; set; }
		[Ordinal(5)] [RED("styleName")] public CName StyleName { get; set; }
		[Ordinal(6)] [RED("forceStyleName")] public CName ForceStyleName { get; set; }
		[Ordinal(7)] [RED("isFriendlyCarry")] public CBool IsFriendlyCarry { get; set; }
		[Ordinal(8)] [RED("forcedCarryStyle")] public CEnum<gamePSMBodyCarryingStyle> ForcedCarryStyle { get; set; }

		public CarriedObjectEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
