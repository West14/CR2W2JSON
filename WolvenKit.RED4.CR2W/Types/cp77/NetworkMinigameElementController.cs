using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameElementController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("data")] public ElementData Data { get; set; }
		[Ordinal(2)] [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(3)] [RED("textNormalColor")] public CColor TextNormalColor { get; set; }
		[Ordinal(4)] [RED("textHighlightColor")] public CColor TextHighlightColor { get; set; }
		[Ordinal(5)] [RED("bg")] public inkRectangleWidgetReference Bg { get; set; }
		[Ordinal(6)] [RED("colorAccent")] public inkWidgetReference ColorAccent { get; set; }
		[Ordinal(7)] [RED("dimmedOpacity")] public CFloat DimmedOpacity { get; set; }
		[Ordinal(8)] [RED("notDimmedOpacity")] public CFloat NotDimmedOpacity { get; set; }
		[Ordinal(9)] [RED("defaultFontSize")] public CInt32 DefaultFontSize { get; set; }
		[Ordinal(10)] [RED("wasConsumed")] public CBool WasConsumed { get; set; }
		[Ordinal(11)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }

		public NetworkMinigameElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
