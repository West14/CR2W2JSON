using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalMainLayoutWidgetController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("thumbnailsListSlot")] public inkWidgetReference ThumbnailsListSlot { get; set; }
		[Ordinal(2)] [RED("deviceSlot")] public inkWidgetReference DeviceSlot { get; set; }
		[Ordinal(3)] [RED("returnButton")] public inkWidgetReference ReturnButton { get; set; }
		[Ordinal(4)] [RED("titleWidget")] public inkTextWidgetReference TitleWidget { get; set; }
		[Ordinal(5)] [RED("backgroundImage")] public inkImageWidgetReference BackgroundImage { get; set; }
		[Ordinal(6)] [RED("backgroundImageTrace")] public inkImageWidgetReference BackgroundImageTrace { get; set; }
		[Ordinal(7)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(8)] [RED("main_canvas")] public wCHandle<inkWidget> Main_canvas { get; set; }

		public TerminalMainLayoutWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
