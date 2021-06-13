using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksPointsDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("desc1Text")] public inkTextWidgetReference Desc1Text { get; set; }
		[Ordinal(2)] [RED("value1Text")] public inkTextWidgetReference Value1Text { get; set; }
		[Ordinal(3)] [RED("icon1")] public inkImageWidgetReference Icon1 { get; set; }
		[Ordinal(4)] [RED("desc2Text")] public inkTextWidgetReference Desc2Text { get; set; }
		[Ordinal(5)] [RED("value2Text")] public inkTextWidgetReference Value2Text { get; set; }
		[Ordinal(6)] [RED("icon2")] public inkImageWidgetReference Icon2 { get; set; }

		public PerksPointsDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
