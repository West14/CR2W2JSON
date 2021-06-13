using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleDoor_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)] [RED("doorAction")] public CEnum<vehicleEQuestVehicleDoorState> DoorAction { get; set; }
		[Ordinal(2)] [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }
		[Ordinal(3)] [RED("toOpen")] public CBool ToOpen { get; set; }
		[Ordinal(4)] [RED("doorID")] public CName DoorID { get; set; }

		public questToggleDoor_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
