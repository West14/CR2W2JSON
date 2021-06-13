using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitBase : CVariable
	{
		[Ordinal(0)] [RED("restitution")] public CFloat Restitution { get; set; }
		[Ordinal(1)] [RED("bounceThreshold")] public CFloat BounceThreshold { get; set; }
		[Ordinal(2)] [RED("stiffness")] public CFloat Stiffness { get; set; }
		[Ordinal(3)] [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(4)] [RED("contactDistance")] public CFloat ContactDistance { get; set; }

		public physicsPhysicsJointLimitBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
