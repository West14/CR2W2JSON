using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFastTravelLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(1)] [RED("mainBackgroundImage")] public inkImageWidgetReference MainBackgroundImage { get; set; }
		[Ordinal(2)] [RED("supportBackgroundImage")] public inkImageWidgetReference SupportBackgroundImage { get; set; }
		[Ordinal(3)] [RED("introAnimationName")] public CName IntroAnimationName { get; set; }
		[Ordinal(4)] [RED("loopAnimationName")] public CName LoopAnimationName { get; set; }
		[Ordinal(5)] [RED("tooltipAnimName")] public CName TooltipAnimName { get; set; }
		[Ordinal(6)] [RED("breathInAnimName")] public CName BreathInAnimName { get; set; }
		[Ordinal(7)] [RED("breathOutAnimName")] public CName BreathOutAnimName { get; set; }
		[Ordinal(8)] [RED("tooltipsWidget")] public inkRichTextBoxWidgetReference TooltipsWidget { get; set; }
		[Ordinal(9)] [RED("progressBarRoot")] public inkWidgetReference ProgressBarRoot { get; set; }
		[Ordinal(10)] [RED("progressBarController")] public wCHandle<LoadingScreenProgressBarController> ProgressBarController { get; set; }

		public inkFastTravelLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
