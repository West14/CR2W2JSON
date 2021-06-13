using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListItemController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(2)] [RED("level")] public inkTextWidgetReference Level { get; set; }
		[Ordinal(3)] [RED("trackedMarker")] public inkWidgetReference TrackedMarker { get; set; }
		[Ordinal(4)] [RED("districtIcon")] public inkImageWidgetReference DistrictIcon { get; set; }
		[Ordinal(5)] [RED("stateIcon")] public inkImageWidgetReference StateIcon { get; set; }
		[Ordinal(6)] [RED("distance")] public inkTextWidgetReference Distance { get; set; }
		[Ordinal(7)] [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(8)] [RED("newIcon")] public inkWidgetReference NewIcon { get; set; }
		[Ordinal(9)] [RED("data")] public CHandle<QuestListItemData> Data { get; set; }
		[Ordinal(10)] [RED("closestObjective")] public CHandle<QuestListDistanceData> ClosestObjective { get; set; }
		[Ordinal(11)] [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(12)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public QuestListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
