using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Movement : animAnimFeature
	{
		[Ordinal(0)] [RED("movementDirection")] public Vector4 MovementDirection { get; set; }
		[Ordinal(1)] [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(2)] [RED("desiredSpeed")] public CFloat DesiredSpeed { get; set; }
		[Ordinal(3)] [RED("stabilizedSpeed")] public CFloat StabilizedSpeed { get; set; }
		[Ordinal(4)] [RED("acceleration")] public CFloat Acceleration { get; set; }
		[Ordinal(5)] [RED("timeToChangeLocomotion")] public CFloat TimeToChangeLocomotion { get; set; }
		[Ordinal(6)] [RED("strafeYaw")] public CFloat StrafeYaw { get; set; }
		[Ordinal(7)] [RED("yawSpeed")] public CFloat YawSpeed { get; set; }
		[Ordinal(8)] [RED("locomotionState")] public CInt32 LocomotionState { get; set; }

		public animAnimFeature_Movement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
