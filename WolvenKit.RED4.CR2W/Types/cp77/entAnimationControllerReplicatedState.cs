using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimationControllerReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("animWrapperVarsState")] public entReplicatedAnimWrapperVars AnimWrapperVarsState { get; set; }
		[Ordinal(3)] [RED("lookAtReqs.m_replicatedVersionId")] public CUInt32 LookAtReqs_m_replicatedVersionId { get; set; }
		[Ordinal(4)] [RED("animFeaturesState")] public entReplicatedAnimFeaturesState AnimFeaturesState { get; set; }
		[Ordinal(5)] [RED("inputSettersState")] public entReplicatedInputSetters InputSettersState { get; set; }

		public entAnimationControllerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
