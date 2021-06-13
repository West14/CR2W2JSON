using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Crowd : animAnimFeature
	{
		[Ordinal(0)] [RED("stopType")] public CInt32 StopType { get; set; }
		[Ordinal(1)] [RED("speedType")] public CInt32 SpeedType { get; set; }
		[Ordinal(2)] [RED("speedOverrideType")] public CInt32 SpeedOverrideType { get; set; }
		[Ordinal(3)] [RED("bumpDirection")] public CInt32 BumpDirection { get; set; }
		[Ordinal(4)] [RED("threatSource")] public CInt32 ThreatSource { get; set; }
		[Ordinal(5)] [RED("locomotionState")] public CInt32 LocomotionState { get; set; }
		[Ordinal(6)] [RED("bumpSourceLocation")] public CInt32 BumpSourceLocation { get; set; }
		[Ordinal(7)] [RED("lookAtAngle")] public CFloat LookAtAngle { get; set; }
		[Ordinal(8)] [RED("fearStage")] public CInt32 FearStage { get; set; }
		[Ordinal(9)] [RED("startType")] public CInt32 StartType { get; set; }
		[Ordinal(10)] [RED("startDirectionAngle")] public CFloat StartDirectionAngle { get; set; }
		[Ordinal(11)] [RED("animTime")] public CFloat AnimTime { get; set; }
		[Ordinal(12)] [RED("isBlocked")] public CBool IsBlocked { get; set; }
		[Ordinal(13)] [RED("bumpType")] public CInt32 BumpType { get; set; }
		[Ordinal(14)] [RED("fleeType")] public CInt32 FleeType { get; set; }

		public animAnimFeature_Crowd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
