using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderHighlightEvent : redEvent
	{
		[Ordinal(0)] [RED("fillIndex")] public CUInt8 FillIndex { get; set; }
		[Ordinal(1)] [RED("outlineIndex")] public CUInt8 OutlineIndex { get; set; }
		[Ordinal(2)] [RED("seeThroughWalls")] public CBool SeeThroughWalls { get; set; }
		[Ordinal(3)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(4)] [RED("opacity")] public CFloat Opacity { get; set; }

		public entRenderHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
