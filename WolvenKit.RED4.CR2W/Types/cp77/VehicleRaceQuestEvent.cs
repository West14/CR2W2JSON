using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRaceQuestEvent : redEvent
	{
		[Ordinal(0)] [RED("mode")] public CEnum<vehicleRaceUI> Mode { get; set; }
		[Ordinal(1)] [RED("maxPosition")] public CInt32 MaxPosition { get; set; }
		[Ordinal(2)] [RED("maxCheckpoints")] public CInt32 MaxCheckpoints { get; set; }

		public VehicleRaceQuestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
