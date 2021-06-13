using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpawned_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] [RED("vehicleType")] public CEnum<questSpawnedVehicleType> VehicleType { get; set; }
		[Ordinal(1)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(2)] [RED("count")] public CUInt32 Count { get; set; }
		[Ordinal(3)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(4)] [RED("vehicleName")] public CString VehicleName { get; set; }
		[Ordinal(5)] [RED("vehicleGlobalName")] public CName VehicleGlobalName { get; set; }

		public questVehicleSpawned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
