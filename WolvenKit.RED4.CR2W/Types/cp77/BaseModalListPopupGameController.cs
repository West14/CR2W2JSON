using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseModalListPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("content")] public inkWidgetReference Content { get; set; }
		[Ordinal(3)] [RED("listController")] public wCHandle<inkVirtualListController> ListController { get; set; }
		[Ordinal(4)] [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(5)] [RED("popupData")] public CHandle<inkGameNotificationData> PopupData { get; set; }
		[Ordinal(6)] [RED("templateClassifier")] public CHandle<BaseModalListPopupTemplateClassifier> TemplateClassifier { get; set; }
		[Ordinal(7)] [RED("systemRequestsHandler")] public wCHandle<inkISystemRequestsHandler> SystemRequestsHandler { get; set; }
		[Ordinal(8)] [RED("switchAnimProxy")] public CHandle<inkanimProxy> SwitchAnimProxy { get; set; }
		[Ordinal(9)] [RED("transitionAnimProxy")] public CHandle<inkanimProxy> TransitionAnimProxy { get; set; }
		[Ordinal(10)] [RED("c_scrollInputThreshold")] public CFloat C_scrollInputThreshold { get; set; }

		public BaseModalListPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
