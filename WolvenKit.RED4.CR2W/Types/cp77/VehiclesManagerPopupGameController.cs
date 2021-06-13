using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehiclesManagerPopupGameController : BaseModalListPopupGameController
	{
		[Ordinal(11)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(12)] [RED("scrollArea")] public inkScrollAreaWidgetReference ScrollArea { get; set; }
		[Ordinal(13)] [RED("scrollControllerWidget")] public inkWidgetReference ScrollControllerWidget { get; set; }
		[Ordinal(14)] [RED("dataView")] public CHandle<VehiclesManagerDataView> DataView { get; set; }
		[Ordinal(15)] [RED("dataSource")] public CHandle<inkScriptableDataSourceWrapper> DataSource { get; set; }
		[Ordinal(16)] [RED("quickSlotsManager")] public wCHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(17)] [RED("scrollController")] public wCHandle<inkScrollController> ScrollController { get; set; }

		public VehiclesManagerPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
