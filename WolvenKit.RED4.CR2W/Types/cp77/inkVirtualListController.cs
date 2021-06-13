using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualListController : inkVirtualCompoundController
	{
		[Ordinal(6)] [RED("itemTemplates")] public CArray<inkWidgetLibraryReference> ItemTemplates { get; set; }
		[Ordinal(7)] [RED("cycleNavigation")] public CBool CycleNavigation { get; set; }

		public inkVirtualListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
