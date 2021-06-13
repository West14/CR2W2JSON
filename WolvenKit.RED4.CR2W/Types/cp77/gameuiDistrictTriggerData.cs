using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDistrictTriggerData : CVariable
	{
		[Ordinal(0)] [RED("district")] public CEnum<gamedataDistrict> District { get; set; }
		[Ordinal(1)] [RED("triggerName")] public CName TriggerName { get; set; }

		public gameuiDistrictTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
