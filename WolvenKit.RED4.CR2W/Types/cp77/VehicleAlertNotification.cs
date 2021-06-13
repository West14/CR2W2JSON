using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleAlertNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("animation")] public CHandle<inkanimProxy> Animation { get; set; }
		[Ordinal(13)] [RED("zone_data")] public CHandle<VehicleAlertNotificationViewData> Zone_data { get; set; }
		[Ordinal(14)] [RED("ZoneLabelText")] public inkTextWidgetReference ZoneLabelText { get; set; }

		public VehicleAlertNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
