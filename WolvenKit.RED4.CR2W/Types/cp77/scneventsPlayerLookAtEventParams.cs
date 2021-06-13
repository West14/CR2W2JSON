using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayerLookAtEventParams : CVariable
	{
		[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)] [RED("offsetPos")] public Vector3 OffsetPos { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("adjustPitch")] public CBool AdjustPitch { get; set; }
		[Ordinal(4)] [RED("adjustYaw")] public CBool AdjustYaw { get; set; }
		[Ordinal(5)] [RED("endOnTargetReached")] public CBool EndOnTargetReached { get; set; }
		[Ordinal(6)] [RED("endOnCameraInputApplied")] public CBool EndOnCameraInputApplied { get; set; }
		[Ordinal(7)] [RED("endOnTimeExceeded")] public CBool EndOnTimeExceeded { get; set; }
		[Ordinal(8)] [RED("cameraInputMagToBreak")] public CFloat CameraInputMagToBreak { get; set; }
		[Ordinal(9)] [RED("precision")] public CFloat Precision { get; set; }
		[Ordinal(10)] [RED("maxDuration")] public CFloat MaxDuration { get; set; }
		[Ordinal(11)] [RED("easeIn")] public CBool EaseIn { get; set; }
		[Ordinal(12)] [RED("easeOut")] public CBool EaseOut { get; set; }

		public scneventsPlayerLookAtEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
