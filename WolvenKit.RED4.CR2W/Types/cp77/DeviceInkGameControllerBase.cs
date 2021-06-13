using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceInkGameControllerBase : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("animationManager")] public CHandle<WidgetAnimationManager> AnimationManager { get; set; }
		[Ordinal(3)] [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(4)] [RED("actionWidgetsData")] public CArray<SActionWidgetPackage> ActionWidgetsData { get; set; }
		[Ordinal(5)] [RED("deviceWidgetsData")] public CArray<SDeviceWidgetPackage> DeviceWidgetsData { get; set; }
		[Ordinal(6)] [RED("breadcrumbStack")] public CArray<SBreadcrumbElementData> BreadcrumbStack { get; set; }
		[Ordinal(7)] [RED("cashedState")] public CEnum<EDeviceStatus> CashedState { get; set; }
		[Ordinal(8)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(9)] [RED("hasUICameraZoom")] public CBool HasUICameraZoom { get; set; }
		[Ordinal(10)] [RED("activeBreadcrumb")] public SBreadcrumbElementData ActiveBreadcrumb { get; set; }
		[Ordinal(11)] [RED("onRefreshListener")] public CUInt32 OnRefreshListener { get; set; }
		[Ordinal(12)] [RED("onActionWidgetsUpdateListener")] public CUInt32 OnActionWidgetsUpdateListener { get; set; }
		[Ordinal(13)] [RED("onDeviceWidgetsUpdateListener")] public CUInt32 OnDeviceWidgetsUpdateListener { get; set; }
		[Ordinal(14)] [RED("onBreadcrumbBarUpdateListener")] public CUInt32 OnBreadcrumbBarUpdateListener { get; set; }
		[Ordinal(15)] [RED("bbCallbacksRegistered")] public CBool BbCallbacksRegistered { get; set; }

		public DeviceInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
