using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMasterDeviceComponent : gameComponent
	{
		[Ordinal(4)] [RED("clearance")] public CHandle<gamedeviceClearance> Clearance { get; set; }

		public gameMasterDeviceComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
