using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapLegendController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("list")] public inkCompoundWidgetReference List { get; set; }
		[Ordinal(2)] [RED("initialized")] public CBool Initialized { get; set; }
		[Ordinal(3)] [RED("visible")] public CBool Visible { get; set; }

		public WorldMapLegendController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
