using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileFollowTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] [RED("startVel")] public CFloat StartVel { get; set; }
		[Ordinal(1)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(2)] [RED("targetComponent")] public wCHandle<entIPlacedComponent> TargetComponent { get; set; }
		[Ordinal(3)] [RED("accuracy")] public CFloat Accuracy { get; set; }
		[Ordinal(4)] [RED("targetOffset")] public Vector4 TargetOffset { get; set; }

		public gameprojectileFollowTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
