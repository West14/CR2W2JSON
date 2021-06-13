using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialOverlayLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("hideInMenu")] public CBool HideInMenu { get; set; }
		[Ordinal(2)] [RED("hideOnInput")] public CBool HideOnInput { get; set; }
		[Ordinal(3)] [RED("showAnimation")] public CName ShowAnimation { get; set; }
		[Ordinal(4)] [RED("hideAnimation")] public CName HideAnimation { get; set; }
		[Ordinal(5)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(6)] [RED("tutorialManager")] public wCHandle<questTutorialManager> TutorialManager { get; set; }

		public gameuiTutorialOverlayLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
