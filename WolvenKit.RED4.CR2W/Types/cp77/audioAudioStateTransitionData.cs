using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioStateTransitionData : CVariable
	{
		[Ordinal(0)] [RED("targetStateId")] public CUInt8 TargetStateId { get; set; }
		[Ordinal(1)] [RED("allConditionsFulfilled")] public CBool AllConditionsFulfilled { get; set; }
		[Ordinal(2)] [RED("transitionTime")] public CFloat TransitionTime { get; set; }
		[Ordinal(3)] [RED("exitTime")] public CFloat ExitTime { get; set; }
		[Ordinal(4)] [RED("exitSignal")] public CName ExitSignal { get; set; }
		[Ordinal(5)] [RED("readVariableActions")] public CArray<audioAudioSceneVariableReadActionData> ReadVariableActions { get; set; }
		[Ordinal(6)] [RED("conditions")] public CArray<CName> Conditions { get; set; }

		public audioAudioStateTransitionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
