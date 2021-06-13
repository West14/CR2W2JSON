using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotResourceComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("resource")] public rRef<workWorkspotResource> Resource { get; set; }
		[Ordinal(6)] [RED("npcResource")] public rRef<workWorkspotResource> NpcResource { get; set; }
		[Ordinal(7)] [RED("deviceResource")] public rRef<workWorkspotResource> DeviceResource { get; set; }
		[Ordinal(8)] [RED("syncSlotName")] public CName SyncSlotName { get; set; }
		[Ordinal(9)] [RED("shouldCrouch")] public CBool ShouldCrouch { get; set; }

		public workWorkspotResourceComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
