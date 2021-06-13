using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsDetailViewController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("StatLabelRef")] public inkTextWidgetReference StatLabelRef { get; set; }
		[Ordinal(2)] [RED("StatValueRef")] public inkTextWidgetReference StatValueRef { get; set; }

		public StatsDetailViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
