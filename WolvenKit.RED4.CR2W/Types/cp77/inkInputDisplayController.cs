using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInputDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("iconRef")] public inkWidgetReference IconRef { get; set; }
		[Ordinal(2)] [RED("nameRef")] public inkWidgetReference NameRef { get; set; }
		[Ordinal(3)] [RED("canvasRef")] public inkWidgetReference CanvasRef { get; set; }
		[Ordinal(4)] [RED("holdIndicatorContainerRef")] public inkCompoundWidgetReference HoldIndicatorContainerRef { get; set; }
		[Ordinal(5)] [RED("gamepadHoldIndicatorLibraryRef")] public inkWidgetLibraryReference GamepadHoldIndicatorLibraryRef { get; set; }
		[Ordinal(6)] [RED("keyboardHoldIndicatorLibraryRef")] public inkWidgetLibraryReference KeyboardHoldIndicatorLibraryRef { get; set; }
		[Ordinal(7)] [RED("supportAnimatedHoldIndicator")] public CBool SupportAnimatedHoldIndicator { get; set; }
		[Ordinal(8)] [RED("holdIndicationType")] public CEnum<inkInputHintHoldIndicationType> HoldIndicationType { get; set; }
		[Ordinal(9)] [RED("inputActionName")] public CName InputActionName { get; set; }
		[Ordinal(10)] [RED("fixedIconHeight")] public CFloat FixedIconHeight { get; set; }

		public inkInputDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
