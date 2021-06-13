using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveSignDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] [RED("messageWidgetPath")] public CName MessageWidgetPath { get; set; }
		[Ordinal(11)] [RED("backgroundWidgetPath")] public CName BackgroundWidgetPath { get; set; }
		[Ordinal(12)] [RED("messageWidget")] public wCHandle<inkTextWidget> MessageWidget { get; set; }
		[Ordinal(13)] [RED("backgroundWidget")] public wCHandle<inkWidget> BackgroundWidget { get; set; }

		public InteractiveSignDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
