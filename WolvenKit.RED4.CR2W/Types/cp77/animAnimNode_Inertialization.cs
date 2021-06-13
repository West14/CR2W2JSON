using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Inertialization : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("safeMode")] public CBool SafeMode { get; set; }
		[Ordinal(13)] [RED("transformsCountUpperBound")] public CUInt32 TransformsCountUpperBound { get; set; }
		[Ordinal(14)] [RED("tracksCountUpperBound")] public CUInt32 TracksCountUpperBound { get; set; }
		[Ordinal(15)] [RED("rotationLimits")] public CArray<animInertializationRotationLimit> RotationLimits { get; set; }

		public animAnimNode_Inertialization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
