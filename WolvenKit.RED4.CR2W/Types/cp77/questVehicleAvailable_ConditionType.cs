using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleAvailable_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] [RED("vehicleType")] public CEnum<questAvailableVehicleType> VehicleType { get; set; }
		[Ordinal(1)] [RED("vehicleName")] public CString VehicleName { get; set; }

		public questVehicleAvailable_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
