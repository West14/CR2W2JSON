using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarsController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("mask")] public inkWidgetReference Mask { get; set; }

		public ProgressBarsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
