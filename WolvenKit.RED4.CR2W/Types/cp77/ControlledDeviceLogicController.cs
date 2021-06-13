using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ControlledDeviceLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("deviceIcon")] public wCHandle<inkImageWidget> DeviceIcon { get; set; }
		[Ordinal(2)] [RED("activeBg")] public wCHandle<inkRectangleWidget> ActiveBg { get; set; }

		public ControlledDeviceLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
