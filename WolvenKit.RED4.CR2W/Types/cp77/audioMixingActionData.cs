using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMixingActionData : CVariable
	{
		[Ordinal(0)] [RED("actionType")] public CEnum<audioMixingActionType> ActionType { get; set; }
		[Ordinal(1)] [RED("voContext")] public CEnum<locVoiceoverContext> VoContext { get; set; }
		[Ordinal(2)] [RED("tagValue")] public CName TagValue { get; set; }
		[Ordinal(3)] [RED("dbOffset")] public CFloat DbOffset { get; set; }
		[Ordinal(4)] [RED("distanceRolloffFactor")] public CFloat DistanceRolloffFactor { get; set; }
		[Ordinal(5)] [RED("voEventOverride")] public CName VoEventOverride { get; set; }
		[Ordinal(6)] [RED("customParametersSetKey")] public CUInt64 CustomParametersSetKey { get; set; }
		[Ordinal(7)] [RED("customParameters")] public CArray<audioAudSimpleParameter> CustomParameters { get; set; }

		public audioMixingActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
