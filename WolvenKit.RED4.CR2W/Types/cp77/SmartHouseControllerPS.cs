using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartHouseControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("timetable")] public CArray<SPresetTimetableEntry> Timetable { get; set; }
		[Ordinal(105)] [RED("activePreset")] public CHandle<SmartHousePreset> ActivePreset { get; set; }
		[Ordinal(106)] [RED("availablePresets")] public CArray<CHandle<SmartHousePreset>> AvailablePresets { get; set; }
		[Ordinal(107)] [RED("smartHouseCustomization")] public SmartHouseConfiguration SmartHouseCustomization { get; set; }
		[Ordinal(108)] [RED("callbackID")] public CUInt32 CallbackID { get; set; }

		public SmartHouseControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
