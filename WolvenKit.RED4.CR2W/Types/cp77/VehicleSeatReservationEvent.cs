using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleSeatReservationEvent : redEvent
	{
		[Ordinal(0)] [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(1)] [RED("reserve")] public CBool Reserve { get; set; }

		public VehicleSeatReservationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
