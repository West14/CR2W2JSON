using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneAnimationMotionActionParams : IScriptable
	{
		[Ordinal(0)] [RED("motionType")] public CEnum<gameSceneAnimationMotionActionParamsMotionType> MotionType { get; set; }
		[Ordinal(1)] [RED("placementTransform")] public WorldTransform PlacementTransform { get; set; }
		[Ordinal(2)] [RED("motionBlendInTime")] public CFloat MotionBlendInTime { get; set; }
		[Ordinal(3)] [RED("poseBlendInTime")] public CFloat PoseBlendInTime { get; set; }
		[Ordinal(4)] [RED("blendInCurve")] public CEnum<gameSceneAnimationMotionActionParamsEasingType> BlendInCurve { get; set; }
		[Ordinal(5)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(6)] [RED("placementMode")] public CEnum<gameSceneAnimationMotionActionParamsPlacementMode> PlacementMode { get; set; }
		[Ordinal(7)] [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(8)] [RED("endTime")] public CFloat EndTime { get; set; }
		[Ordinal(9)] [RED("initialDt")] public CFloat InitialDt { get; set; }
		[Ordinal(10)] [RED("globalTimeToAnimTime")] public CFloat GlobalTimeToAnimTime { get; set; }
		[Ordinal(11)] [RED("mountDescriptor")] public gameMountDescriptor MountDescriptor { get; set; }
		[Ordinal(12)] [RED("playerParams")] public gameScenePlayerAnimationParams PlayerParams { get; set; }
		[Ordinal(13)] [RED("HACK_eventPlayDirection")] public CEnum<gameSceneAnimationMotionActionParamsActionPlayDirection> HACK_eventPlayDirection { get; set; }
		[Ordinal(14)] [RED("trajectoryLOD")] public CArray<scnAnimationMotionSample> TrajectoryLOD { get; set; }
		[Ordinal(15)] [RED("dynamicAnimSetupHash")] public CUInt64 DynamicAnimSetupHash { get; set; }

		public gameSceneAnimationMotionActionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
