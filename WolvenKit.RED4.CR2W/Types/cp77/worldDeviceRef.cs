using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDeviceRef : CVariable
	{
		[Ordinal(0)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(1)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(2)] [RED("deviceClassName")] public CName DeviceClassName { get; set; }

		public worldDeviceRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
