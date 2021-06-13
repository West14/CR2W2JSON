using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVehicleSystem : gameIVehicleSystem
	{
		[Ordinal(0)] [RED("restrictionTags")] public CArray<CName> RestrictionTags { get; set; }

		public gameVehicleSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
