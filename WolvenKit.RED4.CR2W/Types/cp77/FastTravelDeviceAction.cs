using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelDeviceAction : ActionBool
	{
		[Ordinal(25)] [RED("fastTravelPointData")] public CHandle<gameFastTravelPointData> FastTravelPointData { get; set; }

		public FastTravelDeviceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
