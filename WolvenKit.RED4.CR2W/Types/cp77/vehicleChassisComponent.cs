using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleChassisComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("collisionResource")] public rRef<physicsSystemResource> CollisionResource { get; set; }
		[Ordinal(6)] [RED("optionalPlayerOnlyCollisionResource")] public rRef<physicsSystemResource> OptionalPlayerOnlyCollisionResource { get; set; }

		public vehicleChassisComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
