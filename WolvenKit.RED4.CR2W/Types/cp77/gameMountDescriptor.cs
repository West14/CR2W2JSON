using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMountDescriptor : CVariable
	{
		[Ordinal(0)] [RED("parentId")] public entEntityID ParentId { get; set; }
		[Ordinal(1)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)] [RED("initialTransform")] public Transform InitialTransform { get; set; }
		[Ordinal(3)] [RED("state")] public CEnum<gamePuppetVehicleState> State { get; set; }
		[Ordinal(4)] [RED("mountType")] public CEnum<gameMountDescriptorMountType> MountType { get; set; }

		public gameMountDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
