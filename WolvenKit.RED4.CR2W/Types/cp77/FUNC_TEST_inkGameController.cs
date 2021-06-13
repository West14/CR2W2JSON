using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FUNC_TEST_inkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("Canvas")] public inkCanvasWidgetReference Canvas { get; set; }
		[Ordinal(3)] [RED("HorizontalPanel")] public inkHorizontalPanelWidgetReference HorizontalPanel { get; set; }
		[Ordinal(4)] [RED("VerticalPanel")] public inkVerticalPanelWidgetReference VerticalPanel { get; set; }
		[Ordinal(5)] [RED("Flex")] public inkFlexWidgetReference Flex { get; set; }
		[Ordinal(6)] [RED("UniformGrid")] public inkUniformGridWidgetReference UniformGrid { get; set; }
		[Ordinal(7)] [RED("Text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(8)] [RED("TextInput")] public inkTextInputWidgetReference TextInput { get; set; }
		[Ordinal(9)] [RED("Image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(10)] [RED("Video")] public inkVideoWidgetReference Video { get; set; }
		[Ordinal(11)] [RED("Border")] public inkBorderWidgetReference Border { get; set; }
		[Ordinal(12)] [RED("Rectangle")] public inkRectangleWidgetReference Rectangle { get; set; }
		[Ordinal(13)] [RED("Circle")] public inkCircleWidgetReference Circle { get; set; }
		[Ordinal(14)] [RED("Shape")] public inkShapeWidgetReference Shape { get; set; }
		[Ordinal(15)] [RED("BasicInputFields")] public FUNC_TEST_Container_2 BasicInputFields { get; set; }
		[Ordinal(16)] [RED("AdditionalFields")] public FUNC_TEST_Container AdditionalFields { get; set; }

		public FUNC_TEST_inkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
