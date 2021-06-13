using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsVehicleHitEvent : gameeventsHitEvent
	{
		[Ordinal(12)] [RED("vehicleVelocity")] public Vector4 VehicleVelocity { get; set; }
		[Ordinal(13)] [RED("preyVelocity")] public Vector4 PreyVelocity { get; set; }

		public gameeventsVehicleHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
