using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDumpBodyDelayEvent : redEvent
	{
		[Ordinal(0)] [RED("bodyToDump")] public wCHandle<gameObject> BodyToDump { get; set; }
		[Ordinal(1)] [RED("psm")] public CHandle<gameIBlackboard> Psm { get; set; }

		public VehicleDumpBodyDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
