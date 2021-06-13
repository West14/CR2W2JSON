using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUILoadingBarController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("minSize")] public Vector2 MinSize { get; set; }
		[Ordinal(2)] [RED("maxSize")] public Vector2 MaxSize { get; set; }
		[Ordinal(3)] [RED("imageWidgetPath")] public CName ImageWidgetPath { get; set; }
		[Ordinal(4)] [RED("textWidgetPath")] public CName TextWidgetPath { get; set; }
		[Ordinal(5)] [RED("currentSize")] public Vector2 CurrentSize { get; set; }
		[Ordinal(6)] [RED("imageWidget")] public wCHandle<inkImageWidget> ImageWidget { get; set; }
		[Ordinal(7)] [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }

		public sampleUILoadingBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
