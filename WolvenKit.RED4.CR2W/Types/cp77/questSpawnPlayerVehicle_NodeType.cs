using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnPlayerVehicle_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("despawn")] public CBool Despawn { get; set; }
		[Ordinal(1)] [RED("positionRef")] public CHandle<questUniversalRef> PositionRef { get; set; }
		[Ordinal(2)] [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(3)] [RED("driveIn")] public CBool DriveIn { get; set; }
		[Ordinal(4)] [RED("vehicle")] public CString Vehicle { get; set; }
		[Ordinal(5)] [RED("vehicleGlobalName")] public CName VehicleGlobalName { get; set; }
		[Ordinal(6)] [RED("despawnAllVehicles")] public CBool DespawnAllVehicles { get; set; }

		public questSpawnPlayerVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
